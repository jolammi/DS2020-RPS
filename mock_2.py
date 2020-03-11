import socket
import threading
TCP_IP = '192.168.43.112'
##TCP_IP = '192.168.43.75'
TCP_PORT = 5005
BUFFER_SIZE = 1024  # Normally 1024, but we want fast response
count = 0
countdown_over = False
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.bind((TCP_IP, TCP_PORT))
s.listen(1)

conn, addr = s.accept()
addr = str(addr)
print (addr)
st = threading.Thread(target=countdown)
while 1:
    try:
        if countDown <= 0:
            countDown = 20
        else:
            countdown = countdown - 1
        data = conn.recv(BUFFER_SIZE)
        #if not data: break
        print (data.decode())
        split_data = data.split(": ")
        if split_data[0] == "alias":
            data = "Countdown: "+ count
        if split_data[0] == "answer":
            print("Answer is: "+ split_data[1])
        if countdown_over == True:
            data = "Outcome: pekka, sami, olli"
            countdown_over == false
        if data != None:
            conn.send(data.encode())
        data = None
    except OSError:
        continue
conn.close()

def countdown():
    global count, countdown_over
    while True:
        time.sleep(1)
        if count == 30:
            count = 0
            countdown_over = True
            time.sleep(3)
        else:
            count = count +1
        print("counting down: "+ count)
