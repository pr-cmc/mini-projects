#Базовый пример Matploplib внутри Tkinter
import matplotlib.pyplot as plt #Импортируем matplotlib
import os #Импортируем модуль системы
from tkinter import * #Импортируем Tkinter
root = Tk() #Создаем окно
plt.plot([0, 7, 9], [0, 8, 6]) #Добавляем координаты на график
plt.savefig("plt.png") #Сохраняем график на диск
img1 = PhotoImage(file='plt.png') #Импортируем картинку в Tkinter окно
c = Canvas(width=650, height=500, bg='white') #Создаем холст для картинки 
c.create_image(1, 1, anchor=NW, image=img1) #Помещаем катринку на холст
os.remove("plt.png") #Удаляем картинку с диска
c.pack() #Ставим холст внутрь окна
root.mainloop() #Открываем окно
