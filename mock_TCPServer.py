from
import socket

TCP_IP = '192.168.43.112'
##TCP_IP = '192.168.43.75'
TCP_PORT = 5005
BUFFER_SIZE = 1024  # Normally 1024, but we want fast response

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.bind((TCP_IP, TCP_PORT))
s.listen(1)

conn, addr = s.accept()
addr = str(addr)
print (addr)
while 1:
    try:
        if countDown <= 0
            countDown = 20
        else:
            countdown = countdown - 1
        data = conn.recv(BUFFER_SIZE)
        #if not data: break
        print (data.decode())
        split_data = data.split(": ")
        if split_data[0] == "alias":
            data = "Gamerooms: GameRoom1, GameRoom2, GameRoom3"
        elif split_data[0] == "join":
            data = "Response: Joined"
        elif split_data[0] == "answer":

        conn.send(data.encode())
    except OSError:
        continue
conn.close()







# below code is from https://www.techbeamers.com/python-tutorial-write-multithreaded-python-server/

#_____________________________________________________________________________________

# SERVER ----------------------
# import socket
# from threading import Thread
# #from SocketServer import ThreadingMixIn

# # Multithreaded Python server : TCP Server Socket Thread Pool
# class ClientThread(Thread):

#     def __init__(self,ip,port):
#         Thread.__init__(self)
#         self.ip = ip
#         self.port = port
#         print ("[+] New server socket thread started for " + ip + ":" + str(port))

#     def run(self):
#         while True :
#             data = conn.recv(2048)
#             print ("Server received data:", data)
#             MESSAGE = input("Multithreaded Python server : Enter Response from Server/Enter exit:")
#             if MESSAGE == 'exit':
#                 break
#             conn.send(MESSAGE.encode())  # echo

# # Multithreaded Python server : TCP Server Socket Program Stub
# #TCP_IP = '0.0.0.0'
# #TCP_PORT = 2004
# TCP_IP = '192.168.43.75'
# TCP_PORT = 5005
# BUFFER_SIZE = 20  # Usually 1024, but we need quick response

# tcpServer = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
# tcpServer.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
# tcpServer.bind((TCP_IP, TCP_PORT))
# threads = []

# while True:
#     tcpServer.listen(4)
#     print ("Multithreaded Python server : Waiting for connections from TCP clients...")
#     (conn, (ip,port)) = tcpServer.accept()
#     newthread = ClientThread(ip,port)
#     newthread.start()
#     threads.append(newthread)

# for t in threads:
#     t.join()



# CLIENT---------------------------------------------------
# # Python TCP Client A
# import socket

# host = "192.168.43.75"#socket.gethostname()
# port = 5005
# BUFFER_SIZE = 2000
# MESSAGE = input("tcpClientA: Enter message/ Enter exit:")

# tcpClientA = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
# tcpClientA.connect((host, port))

# while MESSAGE != 'exit':
#     tcpClientA.send(MESSAGE.encode())
#     data = tcpClientA.recv(BUFFER_SIZE)
#     print("Client2 received data:", data)
#     MESSAGE = input("tcpClientA: Enter message to continue/ Enter exit:")

# tcpClientA.close()