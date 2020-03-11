#!/usr/bin/env python
import argparse
from app import Base, engine, connection, Player, Gameroom
import socket
from threading import Thread, Lock
import atexit

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

    def run(self):
        while True:

            data = self.conn.recv(2048)
            print(data)

# When player starts the client it sends ->
# alias: "player_name"

# Player joins automatically to the room

# When rps is chosen
# answer: "rock"

# Server sends either  (winners) Outcome: "olli", "Jouni"
# and Countdown: "33"

        #
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

    global threads
    threads = []
    listen_thread = ListenForUsersThread(tcp_server)
    listen_thread.start()
    threads.append(listen_thread)
    # rps_server.start()
    is_running = True
    while is_running:
        pass


def close_socket():
    socket.close()

class RPSserver(Thread):
    """Server for RPS game"""
    def __init__(tcp_ip, tcp_port):
        '''Start server'''
        self.TCP_IP = tcp_ip
        self.TCP_PORT = int(tcp_port)


    def accept_player():
        '''adds the player to the player list'''
        pass


    def get_score_for_player():
        '''fetches score for a player from db'''
        pass

    def update_player_score():
        '''updates player's score according to how the game went'''
        pass

    def play_round():
        '''sends roundstart, starts timer, waits 60sec and calculates winner'''
        pass

    def wait_for_answers():
        '''waits 60s for messages from players'''
        pass

    def get_winner():
        '''Calculates winner from round'''
        pass

    def listen_for_messages():
        '''listens for messages from players'''
        pass

    def read_message():
        ''' Read message '''
        pass

    def route_to_another_server():
        '''routes the message to the replica server'''
        pass

    def

    def create_room():
        '''Create room'''
        pass

    def delete_room():
        '''delete a room'''
        pass

    def join_room():
        '''joins the player that sent the message to a room'''
        pass

    def leave_room():
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
