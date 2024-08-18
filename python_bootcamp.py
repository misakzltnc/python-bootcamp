import random

def tas_kagit_makas():
    secenekler = ["taş", "kağıt", "makas"]

    toplam_oyuncu_galibiyeti = 0
    toplam_bilgisayar_galibiyeti = 0
    tur_sayisi = 0

    while True:
        oyuncu_galibiyeti = 0
        bilgisayar_galibiyeti = 0
        tur_sayisi += 1

        print(f"\nTur {tur_sayisi} başladı.")

        while oyuncu_galibiyeti < 2 and bilgisayar_galibiyeti < 2:
            oyuncu_secimi = input("\nSeçiminizi yapın (taş/kağıt/makas) veya 'çıkış' yazın: ").lower()

            if oyuncu_secimi == "çıkış":
                print("Oyundan çıkıyorsunuz. İyi günler!")
                return
            
            if oyuncu_secimi not in secenekler:
                print("Geçersiz seçim! Taş, kağıt ya da makas yazabilirsiniz.")
                continue

            bilgisayar_secimi = random.choice(secenekler)

            print(f"\nSiz: {oyuncu_secimi.capitalize()}")
            print(f"Bilgisayar: {bilgisayar_secimi.capitalize()}")

            if oyuncu_secimi == bilgisayar_secimi:
                print("Berabere!")
            elif (oyuncu_secimi == "taş" and bilgisayar_secimi == "makas") or \
                 (oyuncu_secimi == "kağıt" and bilgisayar_secimi == "taş") or \
                 (oyuncu_secimi == "makas" and bilgisayar_secimi == "kağıt"):
                print("Siz kazandınız!")
                oyuncu_galibiyeti += 1
            else:
                print("Bilgisayar kazandı!")
                bilgisayar_galibiyeti += 1

            print(f"Oyuncu Galibiyetleri: {oyuncu_galibiyeti}")
            print(f"Bilgisayar Galibiyetleri: {bilgisayar_galibiyeti}")

        if oyuncu_galibiyeti == 2:
            toplam_oyuncu_galibiyeti += 1
            print(f"\nBu turu siz kazandınız.")
        else:
            toplam_bilgisayar_galibiyeti += 1
            print(f"\nBu turu bilgisayar kazandı.")

        print(f"Tur {tur_sayisi} bitti.")
        print(f"Toplam Oyuncu Galibiyeti: {toplam_oyuncu_galibiyeti}")
        print(f"Toplam Bilgisayar Galibiyeti: {toplam_bilgisayar_galibiyeti}")

        devam_et = input("Devam etmek istiyor musunuz? (evet/hayır): ").lower()
        bilgisayar_devam = random.choice(["evet", "hayır"])

        if devam_et != "evet" or bilgisayar_devam != "evet":
            if bilgisayar_devam == "hayır":
                print("Bilgisayar oyuna devam etmek istemiyor.")
            break  # Ana döngüden çık ve oyunu bitir

    print(f"\nOynanan tur sayısı: {tur_sayisi}")
    print(f"Toplam Oyuncu Galibiyeti: {toplam_oyuncu_galibiyeti}")
    print(f"Toplam Bilgisayar Galibiyeti: {toplam_bilgisayar_galibiyeti}")
    print("\nOyun sona erdi. Teşekkür ederiz!")

    input("Programı kapatmak için bir tuşa basın...")

if __name__ == "__main__":
    print("\nTaş, Kağıt, Makas Oyununa Hoş Geldiniz!")
    print("\n2 galibiyeti olan oyunu kazanır.")
    print("\nİyi şanslar homosapien :)")

    tas_kagit_makas()
