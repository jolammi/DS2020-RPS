import socket
import threading
import time
TCP_IP = '192.168.43.112'
##TCP_IP = '192.168.43.75'
TCP_PORT = 5005
BUFFER_SIZE = 128  # Normally 1024, but we want fast response
count = 0
countdown_over = False
conn = None
addr = None
data = None
count_data = None
s = None

def countdown():
    global count, countdown_over, count_data
    while True:
        time.sleep(1)
        if count == 30:
            count = 0
            countdown_over = True
            count_data = "Outcome: pekka, sami, olli"
            time.sleep(3)
        else:
            count = count +1
            count_data = "Countdown: "+ str(count)
        print("counting down: "+ str(count))

def send():
    global count, countdown_over, TCP_IP, TCP_PORT, BUFFER_SIZE, data, count_data
    while 1:
        try:
            if data != None:
                split_data = data.split(": ")
                if split_data[0] == "answer":
                    print("Answer is: "+ split_data[1])
                data = None
                
            if count_data != None:
                if countdown_over == True:
                    countdown_over == False
                print("Sent: "+ count_data)
                conn.send(count_data.encode())
                count_data = None

        except OSError:
            continue


def main():
    global count, countdown_over, TCP_IP, TCP_PORT, BUFFER_SIZE, s, conn, addr, data
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.bind((TCP_IP, TCP_PORT))
    s.listen(1)
    conn, addr = s.accept()
    addr = str(addr)
    print (addr)
    st = threading.Thread(target=countdown)
    st.start()
    st_send = threading.Thread(target=send)
    st_send.start()
    while 1:
        try:
            data = conn.recv(BUFFER_SIZE)
            data = str(data.decode())
            #if not data: break
            print (data)
        except OSError:
            continue
    conn.close()


main()