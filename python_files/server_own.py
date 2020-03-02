#!/usr/bin/env python
import argparse
from app import Base, engine, connection, Player, Gameroom
import socket
from threading import Thread, Lock



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

def main_loop():
    lock = Lock()
    rps_server = RPSserver(tcp_port, rooms, lock)
    rps_server.start()
    is_running = True
    while is_running:
        pass


class RPSserver(Thread):
    """Server for RPS game"""
    def __init__():
        '''Start server'''
        pass

    def create_room():
        '''Create room'''
        pass

    def delete_room():
        '''delete a room'''
        pass

    def join_room():
        '''joins the player that sent the message to a room'''
        pass

    def accept_player():
        '''adds the player to the player list'''
        pass


    def leave_room():
        '''removes the player from a room'''
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

    def route_to_another_server():
        '''routes the message to the replica server'''
        pass

    def



if __name__ == "__main__":
    """
    Start a game server
    """
    parser = argparse.ArgumentParser(description='Simple game server')
    parser.add_argument('--tcpport',
                        dest='tcp_port',
                        help='Listening tcp port',
                        default="1234")

    parser.add_argument('--capacity',
                        dest='room_capacity',
                        help='Max players per room',
                        default="2")

    args = parser.parse_args()
    rooms = Rooms(int(args.room_capacity))
    main_loop(args.tcp_port, rooms)
