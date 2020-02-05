import socket
import threading
import tkinter
import time

global s, ss, serverPort, data, addr

jouninIP = "192.168.43.131"
ownIP = "192.168.43.78"
serverPort = 5005
BUFFER_SIZE = 1024  # Normally 1024, but we want fast response

def client_thread():
     global s, jouninIP
     while True:
          try:
               s.connect((jouninIP, serverPort))
          except socket.error:
               continue
     while true:
          try:
               s.send("YK")
               clResponse = s.recv(BUFFER_SIZE)
               print("Sent" + clResponse + "to" + jouninIP)
          except (socket.error):
               continue
          time.sleep(0.1)
     s.close()

def server_thread():
     global s, ss, serverPort, ownIP

     ss.bind((ownIP, serverPort))
     ss.listen(1)
     while True:
          try:
               conn, addr = ss.accept()
               seReceive = conn.recv(BUFFER_SIZE);
               if not data:
                    continue
               print("Received data" + seReceive + "to" + addr)
               conn.send("OK")
               print("Sent" + "OK" + "to" + addr)
          except (socket.error):
               continue
          time.sleep(0.1)

def main():
     global s,ss
     ss = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
     s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
     ct = threading.Thread(target = client_thread)
     st = threading.Thread(target = server_thread)
     ct.start()
     st.start()
     ct.join()
     st.join()
     while True:
          time.sleep(1)

main()