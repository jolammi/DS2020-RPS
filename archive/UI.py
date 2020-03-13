import tkinter as tk
import os


def join():
    pass

def main_screen():
    global login_screen
    global username
    login_screen = tk.Tk()
    login_screen.geometry("200x105")
    login_screen.title("Distributed RPS")
    tk.Label(text="Distributed RPS", bg="white", relief="solid", borderwidth=2, width="150", height="2").pack()
    tk.Label(text="Who are you?").pack()
    username = tk.StringVar()
    username_entry = tk.Entry(login_screen, textvariable = username).pack(fill=tk.X)
    tk.Label(text="").pack
    tk.Button(text="Join", command=join).pack()
 
    login_screen.mainloop()
 
 
main_screen()