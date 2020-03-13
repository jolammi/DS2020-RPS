#!/usr/bin/env python
import argparse
from app import Base, engine, connection, Player, Gameroom, session
import socket
from threading import Thread, Lock
import atexit
import time

# TCP_IP = 'localhost'
# TCP_PORT = 5005
# BUFFER_SIZE = 20  # Normally 1024, but we want fast response

# s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
# s.bind((TCP_IP, TCP_PORT))
# s.listen(1)

# conn, addr = s.accept()
# print('Connection address:', addr)
# while 1:
#     data = conn.recv(BUFFER_SIZE)
#     if not data: break
#     print("received data:", data)
#     conn.send(data)  # echo
# conn.close()


class ClientThread(Thread):

    def __init__(self, ip, port, conn):
        Thread.__init__(self)
        self.ip = ip
        self.port = port
        self.conn = conn
        print(
            "[+] New server socket thread started for " +
            ip + ":" + str(port)
        )
        # tallenna tietokantaan IP ja alias

    def run(self):
        while True:

            data, address = sock.recvfrom(1024)
            print(data)
            data = RPSGame.read_message(data, address)

        # When player starts the client it sends ->
        # alias: "player_name"

        # Player joins automatically to the room

        # When rps is chosen
        # answer: "rock"

        # Server sends either  (winners) Outcome: "olli", "Jouni"
        # and Countdown: "33"

            self.conn.send(data)  # echo


class ListenForUsersThread(Thread):

    def __init__(self, tcp_server):
        self.tcp_server = tcp_server
        Thread.__init__(self)
        print("[+] New server socket thread started for listening for users")

    def run(self):
        while True:
            self.tcp_server.listen(20)
            print("Multithreaded Python server : Waiting for connectionsfrom TCP clients...")
            (conn, (ip, port)) = self.tcp_server.accept()
            newthread = ClientThread(ip, port, conn)
            newthread.start()
            threads.append(newthread)


def main_loop(tcp_ip, tcp_port):

    # rps_server = RPSserver(tcp_ip, tcp_port)
    #  TCP_IP = '0.0.0.0'
    # TCP_PORT = 2004
    # TCP_IP = '192.168.43.75'
    # TCP_PORT = 5005
    # BUFFER_SIZE = 20  # Usually 1024, but we need quick response

    tcp_server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    tcp_server.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    tcp_server.bind((tcp_ip, int(tcp_port)))

    # Start timer

    global threads
    global round_answers
    round_answers = []
    threads = []
    timer_thread =
    listen_thread = ListenForUsersThread(tcp_server)
    listen_thread.start()
    threads.append(listen_thread)
    # rps_server.start()
    is_running = True
    while is_running:
        pass


def close_socket():
    socket.close()



class TimerThread(Thread):

    def __init__(self):
        Thread.__init__(self)
        self.time = 30
        self.round_over = False
        print("Timer thread started")

    def send_time():
        '''sends timer in 10 sec periods'''
        while(1):
            time.sleep(1)
            self.time -= 1
            if self.time <= 0:
                self.round_over = True
                self.time = 30
                time.sleep(10)
                self.round_over = False


class RPSGame():
    """Server for RPS game"""
    def __init__(self):
        '''Start server'''
        pass

    def accept_player(self, data):
        '''adds the player to the player list (database)'''

        pass

    def get_score_for_player(self):
        '''fetches score for a player from db'''
        pass

    def update_player_score(self):
        '''updates player's score according to how the game went'''
        pass

    def play_round(self):
        '''sends roundstart, starts timer, waits 60sec and calculates winner'''
        pass

    def wait_for_answers(self):
        '''waits 60s for messages from players'''
        pass

    def send_scores(self, outcome):
        ''' Send scores of the game Outcome: "alias: 2", "alias2: 0"   '''
        conn.send(outcome)
        pass

    def get_winner(self):
        '''Calculates winner from round'''
        pass

    def listen_for_messages(self):
        '''listens for messages from players'''
        pass

    def read_message(self, message, ip_address):
        ''' Read message '''
        # alias: "player_name"

        # Player joins automatically to the room

        # When rps is chosen
        # answer: "rock"
        message = message.decode()
        message = message.split(";")
        message = [datapair.split(":") for datapair in message]
        message = [[value.strip() for value in sublist] for sublist in message2
        data = {str(sublist[0]): str(sublist[1]) for sublist in message2}
        try:
            if "msgtype" in data:
                if data["msgtype"] == "connect":
                    user = Player(username=data["alias"], ip=ip_address)
                    session.add(user)
                    session.commit()

                if data["msgtype"] == "play":
                    round_answers.append({data["alias"]: data["answer"]})


        except KeyError:
            print("Unhandled exception")

    def route_to_another_server(self):
        '''routes the message to the replica server'''
        pass

    def create_room(self):
        '''Create room'''
        pass

    def delete_room(self):
        '''delete a room'''
        pass

    def join_room(self):
        '''joins the player that sent the message to a room'''
        pass

    def leave_room(self):
        '''removes the player from a room'''
        pass


if __name__ == "__main__":
    """rooms, lock
    Start a game server
    """
    parser = argparse.ArgumentParser(description='Server of RPS')
    parser.add_argument('--TCP_IP',
                        dest='tcp_ip',
                        help='Own TCP IP',
                        default="0.0.0.0")

    parser.add_argument('--TCP_PORT',
                        dest='tcp_port',
                        help='Own tcp port',
                        default=5005)
    args = parser.parse_args()
    atexit.register(close_socket)
    main_loop(args.tcp_ip, args.tcp_port)




    # https://www.techbeamers.com/python-tutorial-write-multithreaded-python-server/
    # https://stackoverflow.com/questions/10810249/python-socket-multiple-clients
    # https://www.geeksforgeeks.org/socket-programming-multi-threading-python/
