# from https://www.techbeamers.com/python-tutorial-write-multithreaded-python-server/
from threading import Thread
# Python TCP Client A
import socket

class RPSClient(Thread):
    """CLI client that playe RPS"""
    def __init__(self):
        self.is_identified = False

    def send_rock():
        return "answer: rock"

    def send_paper():
        return "answer: paper"

    def send_scissors():
        return "answer: scissors"

class _():
    __init__():
        pass






server_address = "192.168.43.75" #socket.gethostname()
port = 5005
BUFFER_SIZE = 2000

tcpClientA = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
tcpClientA.connect((server_address, port))
MESSAGE = "null"
RPSClient()

while(MESSAGE != 'exit'):

    tcpClientA.send(MESSAGE.encode())
    data = tcpClientA.recv(BUFFER_SIZE)
    print("Client2 received data:", data)
    MESSAGE = input("tcpClientA: Enter message to continue/ Enter exit:")

tcpClientA.close()