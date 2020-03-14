#!/usr/bin/env python
import argparse
from app import Base, engine, connection, Player, Session
import socket
from threading import Thread, Lock
import atexit
import time
from sqlite3 import IntegrityError
import traceback
import sys
import os
import logging

logging.basicConfig(
    filename='syslog.log',
    level=logging.DEBUG,
    format='%(asctime)s %(levelname)s %(message)s'
)


class IPBroadcastThread(Thread):
    """Thread for broadbasting the IP via UDP"""
    def __init__(self, ip, sock):
        logging.info("IPBroadcast thread init")
        Thread.__init__(self)
        self.host_ip = ip
        self.udp_port = 4801
        self.key = "IDKEY"
        self.sock = sock

    def run(self):
        try:
            print(self.host_ip)
            logging.info("IP broadcast starting")
            self.sock.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)
            while True:
                self.sock.sendto(
                    self.host_ip.encode(),
                    (self.host_ip, self.udp_port)
                )
                time.sleep(1)
        except Exception:
            logging.exception("Error in IP broadcast loop, killing socket")
            self.sock.close()





class ClientThread(Thread):
    """A thread that is created for each client."""
    def __init__(self, ip, port, conn):
        logging.info("Client thread init")
        Thread.__init__(self)
        self.ip = ip
        self.alias = None
        self.port = port
        self.conn = conn
        print(
            "[+] New server socket thread started for " +
            ip + ":" + str(port), flush=True
        )
        self.exception = None

    def run(self):
        """Main functionality of ClientThread"""
        while True:
            try:
                data = self.conn.recv(1024)
                if data:
                    # logging.info("Client thread for ip %s received data %s" % self.ip, data)
                    print(data.decode(), flush=True)
                    rpsgame = RPSGame()
                    data = rpsgame.handle_message(data, self.ip)
                    # self.conn.send(data.encode())  # echo
                    #self.conn.send(data)

            except OSError:
                logging.exception("OSerror in client thread")
                self.conn.close()

            except ConnectionResetError:
                logging.exception("ConnectionReset happened")
                print("session disconnected by player", flush=True)

            except Exception as e:
                logging.exception("Unhandled exception in client thread for ip %s" % self.ip)
                self.exception = e
                print("exception in client thread", flush=True)
                print(e, flush=True)
                traceback.print_exc()
                sys.stdout.flush()

    def send_round_results(self, round_results):
        """Send round results to clients"""
        try:
            self.conn.send(round_results.encode())
            print("Sent round results:", flush=True)
            print([round_results])
            print(round_results, flush=True)
        except OSError:
            logging.exception("OSError in client thread")
            self.conn.close()

    def send_countdown(self, time):
        """Send """
        try:
            self.conn.send(f"Countdown; {time}".encode())
        except OSError:
            logging.exception("OSError in client thread")
            self.conn.close()

    def get_exception(self):
        return self.exception


class TimerThread(Thread):

    def __init__(self):
        Thread.__init__(self)
        self.time = 30
        self.round_over = False
        self.exception = None
        print("Timer thread started", flush=True)
        logging.info("init TimerThread")

    def run(self):
        '''sends timer in 10 sec periods'''
        while(1):
            try:
                while not self.round_over:
                    time.sleep(1)
                    self.time = self.time - 1
                    try:
                        for thread in client_threads:
                            thread.send_countdown(self.time)
                    except BrokenPipeError:
                        print("pipe broken for client, closing its socket")
                        logging.exception("BrokenPipeError exception")
                        thread.conn.close()
                    if self.time % 5 == 0:
                        print(f"Time left:{self.time}", flush=True)
                    if self.time <= 0:
                        self.round_over = True


            except Exception as e:
                print("exception in timer thread", flush=True)
                self.exception = e
                logging.exception("TimerThread exception")
                traceback.print_exc()
                sys.stdout.flush()

    def get_exception(self):
        return self.exception


class ListenForUsersThread(Thread):

    def __init__(self, tcp_server):
        self.tcp_server = tcp_server
        self.exception = None
        Thread.__init__(self)
        logging.info("Init ListenForUserThread")
        print("[+] New server socket thread started for listening for users", flush=True)

    def run(self):

        while True:
            try:
                self.tcp_server.listen(20)
                print("Multithreaded Python server : Waiting for connections from TCP clients...", flush=True)
                (conn, (ip, port)) = self.tcp_server.accept()
                newthread = ClientThread(ip, port, conn)
                newthread.start()
                threads.append(newthread)
                client_threads.append(newthread)

            except Exception as e:
                self.exception = e
                logging.exception("Exception in ListenForUsersThread")
                print("exception in ListenForUserThread", flush=True)

    def get_exception(self):
        return self.exception


class RPSGame():
    """Server for RPS game"""
    def __init__(self):
        '''Start server'''
        logging.info("RPSGame init")
        pass

    def calculate_results(self):
        global round_results
        global total_points
        total_points = {}
        session = Session()

        '''calculates round results'''

        # get all players from the database
        for alias, score in session.query(Player.username, Player.player_id):
            # get info from the round's answers
            for index, (round_alias, answer) in enumerate(round_answers):
                if alias == round_alias:
                    print(alias, score)
                    other_answers = round_answers.copy()
                    other_answers = other_answers[:index] + other_answers[index+1:]
                    points = 0
                    for (other_alias, other_answer) in other_answers:
                        if answer == "rock" and other_answer == "scissors":
                            points += 1
                        elif answer == "paper" and other_answer == "rock":
                            points += 1
                        elif answer == "scissors" and other_answer == "paper":
                            points += 1
                        else:
                            # if tie or loss
                            points += 0

            # if alias in total_points:
            #     total_points[alias] += points
            # else:
            #     total_points[alias] = points
                    player = session.query(Player).filter(Player.username == alias).one()
                    print(player.username)
                    print(player.player_score)
                    total_points[str(player.username)] = int(player.player_score)
                    player.player_score += points
                    session.commit()

        results_table = ', '.join("{!s}: {!r}".format(key, val) for (key, val) in total_points.items())
        round_results = str("Outcome; " + results_table)
        print(round_results, flush=True)
        print(results_table, flush=True)

        # kaikkien vastaukset
        # [('olappi': 'rock'), ('allu': 'paper'), ('samppa': 'rock')]
        # Ollin kierroksella loopissa
        # [('allu': 'paper'), ('samppa': 'rock')]


    def handle_message(self, message, ip_address):
        ''' Read message '''
        # alias: "player_name"

        # Player joins automatically to the room
        # msgtype: alias;
        # When rps is chosen
        # answer: "rock"
        message = message.decode()
        session = Session()
        try:
            message = message.split(";")
            message = [datapair.split(":") for datapair in message]
            message = [[value.strip() for value in sublist] for sublist in message]
            data = {str(sublist[0]): str(sublist[1]) for sublist in message}
            if "msgtype" in data:
                if data["msgtype"] == "connect":
                    player = session.query(Player).filter_by(username=data["alias"]).first()
                    if not player:
                        player = Player(username=data["alias"], ip=ip_address)
                        session.add(player)
                        session.commit()
                        return "connect type msg received"

                if data["msgtype"] == "play":
                    round_answers.append((data["alias"], data["answer"]))
                    logging.info("play type msg received")
                    return "play type msg"

        except KeyError:
            print("Missing fields in clients message", flush=True)
            logging.exception("KeyError in RPSGame")

        except IndexError as e:
            print(e, flush=True)
            logging.exception("IndexError in RPSGame")
            return "Wrong message fields"

        except IntegrityError:
            print("integrityerror in db")
            logging.exception("IntegrityError RPSGame")
        except Exception as e:
            print(" error", flush=True)
            print(e, flush=True)
            logging.exception("Exception in RPSGame")
            return "error in msg"

    def route_to_another_server(self):
        '''routes the message to the replica server'''
        pass




def main_loop(tcp_ip, tcp_port):
    """main loop of the app. Contains the main game engine"""
    global tcp_server
    tcp_server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    tcp_server.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    tcp_server.bind((tcp_ip, int(tcp_port)))
    logging.info("tcp_server ready")

    # Start timer
    global threads
    global client_threads
    global round_answers
    global round_results
    global total_points
    round_answers = []
    client_threads = []
    round_results = "OK"
    total_points = {}
    threads = []
    rps_game = RPSGame()
    timer_thread = TimerThread()
    timer_thread.start()
    listen_thread = ListenForUsersThread(tcp_server)
    listen_thread.start()
    threads.append(timer_thread)
    threads.append(listen_thread)
    is_running = True
    while is_running:
        if timer_thread.round_over:
            logging.info("Round ends")
            rps_game.calculate_results()
            print("Here are the round answers:", flush=True)
            print(round_answers)
            print("Here are the total points:", flush=True)
            print(total_points)
            print("Here is the round results string:", flush=True)
            print(round_results)
            for thread in client_threads:
                logging.info("Send round results to client")
                thread.send_round_results(round_results)
            timer_thread.round_over = False
            timer_thread.time = 30
            round_answers = []


def close_socket():
    tcp_server.close()


if __name__ == "__main__":
    """rooms, lock
    Start a game server
    """
    logging.info("System started, parsing args")
    parser = argparse.ArgumentParser(description='Server of RPS')

    parser.add_argument('--TCP_PORT',
                        dest='tcp_port',
                        help='Own tcp port',
                        default=5005)
    args = parser.parse_args()

    logging.info("args parsed")
    atexit.register(close_socket)
    logging.info("Entering main loop")
    sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    sock.connect(("8.8.8.8", 80))
    host_ip = sock.getsockname()[0]
    print(host_ip)

    ip_broadcast = IPBroadcastThread(host_ip, sock)
    ip_broadcast.start()
    main_loop(host_ip, args.tcp_port)



    # https://www.techbeamers.com/python-tutorial-write-multithreaded-python-server/
    # https://stackoverflow.com/questions/10810249/python-socket-multiple-clients
    # https://www.geeksforgeeks.org/socket-programming-multi-threading-python/


# import socket
# import os
# from time import sleep

# IP = os.popen('ipconfig en0 | grep "inet\ addr" | cut -d: -f2 | cut -d" " -f1').read()
# PORT = 4801
# KEY = "IDKEY"

# # Create socket.
# sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
# # Bind socket.
# sock.bind(('', 0))
# # Configure socket.
# sock.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)

# # Server Loop.
# while True:
#     data = KEY+IP
#     sock.sendto(data.encode(), ('<broadcast>', PORT))
#     print("Sent broadcast")
#     sleep(5)
