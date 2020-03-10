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
            data = "Count: " + countDown
        elif split_data[0] == "answer":
            
        conn.send(data.encode())
    except OSError:
        continue
conn.close()
