import socket

TCP_IP = '172.20.10.2'
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
          data = conn.recv(BUFFER_SIZE)
          #if not data: break
          print (data.decode())
          data = "Gamerooms: GameRoom1, GameRoom2, GameRoom3"
          conn.send(data.encode())
     except OSError:
          continue
conn.close()
