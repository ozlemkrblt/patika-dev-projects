# SQL ÇALIŞMASI ÖDEV-4
---
## İstenilen : 

Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz.

1- Film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralayınız.
```sql
SELECT DISTINCT replacement_cost FROM film;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/3f4a8709-9d5f-4ff9-a73a-51d23a29afdb)

2- Film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?
```sql
SELECT (COUNT(DISTINCT replacement_cost)) FROM film;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/071f855f-feb9-4ba0-8d98-d9f73e0b4f9a)


3- Film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?
```sql
SELECT (COUNT(title)) FROM film WHERE title LIKE 'T%' AND rating = 'G' ;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/1b0651ff-9035-43af-a4c6-e235ba8a84e1)

4- Country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?
```sql
SELECT (COUNT(country)) FROM Country WHERE country LIKE '_____';
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/2340a3d8-4d94-4bab-a8d0-aa7f44b3ee19)


5- City tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?
```sql
SELECT (COUNT(city)) FROM City WHERE city ILIKE '%R';
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/56f874ff-9e81-4c40-ba9b-f19da66696a1)


---

## Kullanılan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabanı](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 

