# Mi az IP cím (IPv4)?

- valamilyen azonosító -> hálózaton belül egyedi

- legyen vmilyen szám: gépek számokkal tudnak kommunikálni

- lehet belső és külső cím 

  - belső

    - CSAK LAN-ON BELÜL LÉTEZIK
    - két különböző LAN-ban lehetnek ugyanazok a címek
    - miért? nem lenne elég cím ha nem így lenne
    - vannak kijelölt belső cím sávok

  - külső

    - az interneten egyedinek kell lennie -> emiatt tudják neked küldeni a csomagot

    - általában a szolgáltatótól kapod

    - gyakorlatilag bárhonnan elérhető

      ---



## Hogyan épül fel egy IP cím?

- 32 bites -> 32db 1 vagy 0-ból áll
- példa: 11110000101010101100110011001111 -> dec: 2^32 ~ 4 milliárd
- erre találták ki -> 8-as csoportokba rendezik (1 csoportot 1 oktett)
- ponttal választják el: 11110000.10101010.11001100.11001111, kicsit kellemesebb hiszen 2^8 = 256
- megoldás minden oktettet átírunk 10-es számrendszerbeli számmá 
- példa 11110000.10101010.11001100.11001111 -> 240.170.204.207



## Na mik ebből a belső IP címek?

- belső IP címekről azt tudjuk, hogy nincsenek kinn az interneten
- csak LAN-on belül vannak
- de mik lehetnek ezek?
- osztályokba rendezték őket:
  - A-B-C-D-E osztályok (mi csak csak A-B-C osztályokkat foglalkozunk)

### A osztály:

- Az IP cím első oktettje 0-val kezdődik pl. **0**1101010..........

- első oktett decimálisan 0-127 között van

- első oktett -> hálózat címei (128db külön hálózat)

- utolsó három oktett pedig az állomások címeire (hálózatonként 2^24 kb 16 millió host)

- pl: hálózat.host.host.host

- privát/belső IP cím tartomány **10**.0.0.0 - **10**.255.255.255-ig tart

- alapértelmezett maszk: /8 -> 255.0.0.0

  

  ### B osztály

  - Az IP első oktettje 10-el kezdődik: pl **10**110011.........
  - első oktett decimálisan 128-191 között van 
  - első két oktett -> 2^14 = 16384 hálózatot jelent
  - utolsó kettő -> 2^16 hálózatonként 65.536 host
  - pl: hálózat.hálózat.host.host
  - privát/belső tartomány: **172**.16.0.0 – **172**.31.255.255-ig tart
  - alapértelmezett maszk: /16 -> 255.255.0.0

  

  ### C osztály 

  - Az IP első oktettje 110-el kezdődik: pl **110**10101.......
  - első oktett decimálisan 192-223 között van
  - első három oktett jelöli a hálózat címét: 2^21 kb 2 millió különböző hálózat
  - utolsó oktett jelöli hálózaton belüli hostok számát 2^8 = 256
  - pl: hálózat.hálózat.hálózat.host

  - privát/belső tartomány: **192.168**.0.0 – **192.168**.255.255
  - alapértelmezett maszk: /24 -> 255.255.255.0



---

## Hogyan tudom egy IP címről, hogy meddig tart a hálózat része? Mennyi a host címe?

- pl. 192.168.1.34 -> erről önmagában sehogy
- viszont alhálózati maszk pont erre való



### Hogyan működik egy maszk?

- 192.168.1.34 
- 11000000.10101000.00000001.00100010 így néz ki binárisan
- 11111111.11111111.11111111.00000000 pedig egy maszk
- bitenként ÉS műveletet végez
- 11000000.10101000.00000001.00000000 -> ez a hálózat címe 
- decimálsan: 192.168.1.0
- hogyan tudjuk megadni? 255.255.255.0 vagy megadjuk hogy hány db 1-es van: /24
- pl: /27-es maszk 255.255.255.11000000(bin) = 255.255.255.192



### Példa1: 192.168.1.56 és 192.168.1.86 egy hálózatban vannak-e ha a maszk /24?

- A(dec): 192.168.1.56
- A:(bin): 11000000.10101000.00000001.00111000
- maszk: 11111111.11111111.11111111.00000000
- B:(bin): 11000000.10101000.00000001.01010110
- B(dec): 192.168.1.86
- A ÉS MASZK: 11000000.10101000.00000001.00000000 -> 192.168.1.0
- B ÉS MASZK: 11000000.10101000.00000001.00000000 -> 192.168.1.0

## Példa2: 192.168.1.43 és 192.168.13.4 egy hálózaton vannak-e ha a maszk /24?

- A(dec): 192.168.1.43
- A:(bin): 11000000.10101000.00000001.00101011
- maszk: 11111111.11111111.11111111.00000000
- B:(bin): 11000000.10101000.00001101.00000100
- B(dec): 192.168.13.4
- A ÉS MASZK: 11000000.10101000.00000001.00000000 -> 192.168.1.0
- B ÉS MASZK: 11000000.10101000.00001101.00000000 -> 192.168.13.0

## Példa3: ua. mint 2 de a maszk /16?

- A(dec): 192.168.1.43
- A:(bin): 11000000.10101000.00000001.00101011
- maszk: 11111111.11111111.00000000.00000000
- B:(bin): 11000000.10101000.00001101.00000100
- B(dec): 192.168.13.4
- A ÉS MASZK: 11000000.10101000.00000000.00000000 -> 192.168.0.0
- B ÉS MASZK: 11000000.10101000.00000000.00000000 -> 192.168.0.0