# -*- coding: utf-8 -*-
# coding by omicr0n
import math
from os import system
import sys
import time

def toplama_islemi():
    sayi1 = float(input("Birinci sayıyı girin: "))
    sayi2 = float(input("İkinci sayıyı girin: "))
    return sayi1 + sayi2

def cikarma_islemi():
    sayi1 = float(input("Birinci sayıyı girin: "))
    sayi2 = float(input("İkinci sayıyı girin: "))
    return sayi1 - sayi2

def carpma_islemi():
    sayi1 = float(input("Birinci sayıyı girin: "))
    sayi2 = float(input("İkinci sayıyı girin: "))
    return sayi1 * sayi2

def bolme_islemi():
    sayi1 = float(input("Birinci sayıyı girin: "))
    sayi2 = float(input("İkinci sayıyı girin: "))
    
    if sayi2 != 0:
        return sayi1 / sayi2
    else:
        print("Hata: Bölen sıfır olamaz!")
        return 0

def us_hesaplama():
    taban = float(input("Tabanı girin: "))
    us = float(input("Üssü girin: "))
    return math.pow(taban, us)

def karekok_hesaplama():
    sayi = float(input("Karekökünü hesaplamak istediğiniz sayıyı girin: "))
    return math.sqrt(sayi)

def mutlak_deger_hesaplama():
    sayi = float(input("Mutlak değerini hesaplamak istediğiniz sayıyı girin: "))
    return abs(sayi)

def akim_hesaplama():
    voltaj = float(input("Voltajı girin (V): "))
    direnc = float(input("Direnç değerini girin (Ω): "))
    return voltaj / direnc

def direnc_hesaplama():
    voltaj = float(input("Voltajı girin (V): "))
    akim = float(input("Akım değerini girin (A): "))
    return voltaj / akim

def alan_hesaplama():
    uzunluk = float(input("Uzunluğu girin: "))
    genislik = float(input("Genişliği girin: "))
    return uzunluk * genislik

def hacim_hesaplama():
    uzunluk = float(input("Uzunluğu girin: "))
    genislik = float(input("Genişliği girin: "))
    yukseklik = float(input("Yüksekliği girin: "))
    return uzunluk * genislik * yukseklik

def alan_cevresi_hesaplama():
    yaricap = float(input("Yarıçapı girin: "))
    return 2 * math.pi * yaricap

def daire_dilimi_alani_hesaplama():
    yaricap = float(input("Yarıçapı girin: "))
    aci = float(input("Merkez Açısını girin (derece): "))
    return (aci / 360) * math.pi * yaricap ** 2

def ucgen_alan_hesaplama():
    taban = float(input("Taban uzunluğunu girin: "))
    yukseklik = float(input("Yüksekliği girin: "))
    return 0.5 * taban * yukseklik

def faktoriyel_hesaplama():
    sayi = int(input("Bir sayı girin: "))
    faktoriyel = 1
    for i in range(1, sayi + 1):
        faktoriyel *= i
    return faktoriyel

def binary_to_decimal():
    binary = input("2'lik tabandaki sayıyı girin: ")
    decimal_value = int(binary, 2)
    return float(decimal_value)

def decimal_to_binary():
    decimal_number = float(input("10'lu tabandaki sayıyı girin: "))
    int_decimal_number = int(decimal_number)
    return float(bin(int_decimal_number)[2:])

def fibonacci_numbers():
    count = int(input("Kaç adet Fibonacci sayısı görmek istediğinizi girin: "))
    a, b = 0, 1
    print("Fibonacci Sayıları:", a, b, end=" ")
    for i in range(2, count):
        c = a + b
        print(c, end=" ")
        a, b = b, c

text = "Coding by Omicron"

colors = ["\033[31m", "\033[33m", "\033[32m", "\033[36m", "\033[34m", "\033[35m", "\033[37m"]

while True:
    print("\n" + "\033[35m=" * 60)
    print("\033[35mMatematik ve Fizik Hesap Makinesi".center(60))
    print("\033[35m=" * 60)

    for i in range(len(text)):
        char = text[i]
        color = colors[i % len(colors)]  # Renkleri döngüsüz uygulama
        sys.stdout.write(color + char)
        sys.stdout.flush()
        time.sleep(0.1)

    print("""
          \n\033[94mLütfen yapmak istediğiniz işlemi seçin:\n""")
    print("\033[31m1 - Toplama")
    print("\033[32m2 - Çıkarma")
    print("\033[31m3 - Çarpma")
    print("\033[32m4 - Bölme")
    print("\033[31m5 - Üs Hesaplama")
    print("\033[32m6 - Karekök Hesaplama")
    print("\033[31m7 - Mutlak Değer Hesaplama")
    print("\033[32m8 - Akım Hesaplama")
    print("\033[31m9 - Direnç Hesaplama")
    print("\033[32m10 - Alan Hesaplama")
    print("\033[31m11 - Hacim Hesaplama")
    print("\033[32m12 - Alan Çevresi Hesaplama")
    print("\033[31m13 - Daire Dilimi Alanı Hesaplama")
    print("\033[32m14 - Üçgen Alan Hesaplama")
    print("\033[31m15 - Faktöriyel Hesaplama")
    print("\033[32m16 - 2'lik Sayıyı 10'lu Sayıya Dönüştürme")
    print("\033[31m17 - 10'lu Sayıyı 2'lik Sayıya Dönüştürme")
    print("\033[32m18 - Fibonacci Sayıları")
    print("\033[37m0 \033[1m - Çıkış")

    secim = int(input("Seçiminizi yapın: "))

    if secim == 0:
        print("\nÇıkış yapılıyor...")
        break

    sonuc = 0

    if secim == 1:
        sonuc = toplama_islemi()
    elif secim == 2:
        sonuc = cikarma_islemi()
    elif secim == 3:
        sonuc = carpma_islemi()
    elif secim == 4:
        sonuc = bolme_islemi()
    elif secim == 5:
        sonuc = us_hesaplama()
    elif secim == 6:
        sonuc = karekok_hesaplama()
    elif secim == 7:
        sonuc = mutlak_deger_hesaplama()
    elif secim == 8:
        sonuc = akim_hesaplama()
    elif secim == 9:
        sonuc = direnc_hesaplama()
    elif secim == 10:
        sonuc = alan_hesaplama()
    elif secim == 11:
        sonuc = hacim_hesaplama()
    elif secim == 12:
        sonuc = alan_cevresi_hesaplama()
    elif secim == 13:
        sonuc = daire_dilimi_alani_hesaplama()
    elif secim == 14:
        sonuc = ucgen_alan_hesaplama()
    elif secim == 15:
        sonuc = faktoriyel_hesaplama()
    elif secim == 16:
        sonuc = binary_to_decimal()
    elif secim == 17:
        sonuc = decimal_to_binary()
    elif secim == 18:
        fibonacci_numbers()
    else:
        print("Geçersiz seçim. Lütfen tekrar deneyin.")

    print("Sonuç:", sonuc)

    input("\nDevam etmek için Enter tuşuna basın...")
    system("cls||clear")
