import socket
import os
from time import sleep

s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
s.connect(("8.8.8.8", 80))
print(s.getsockname()[0])
addr = s.getsockname()[0]
print(s)

KEY = "IDKEY"
UDP_PORT = 4801
s.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)
listeningAddress = (addr, UDP_PORT)
print(listeningAddress)


# Server Loop.
while True:
    print("3")
    #tempVal, sourceAddress = datagramSocket.recvfrom(128);
    print("4")
    #print(sourceAddress)
    print(addr)
    data = addr
    s.sendto(data.encode(), listeningAddress)
    print("Sent broadcast")
    sleep(1)