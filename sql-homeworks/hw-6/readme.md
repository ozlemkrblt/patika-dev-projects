# SQL ÇALIŞMASI ÖDEV-6
---
## İstenilen : 

Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz:

1- Film tablosunda bulunan rental_rate sütunundaki değerlerin ortalaması nedir?


```sql
SELECT ROUND(AVG(rental_rate),2) FROM film;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/2d477047-da43-4d22-a03e-7418b1c20d2c)


2-Film tablosunda bulunan filmlerden kaç tanesi 'C' karakteri ile başlar?

```sql
SELECT COUNT(title) FROM film WHERE title LIKE 'C%';
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/1aa6436e-f1c3-4d1a-bc06-8ce3879d06e6)


3-Film tablosunda bulunan filmlerden rental_rate değeri 0.99 a eşit olan en uzun (length) film kaç dakikadır?


```sql
SELECT MAX(length) FROM film WHERE rental_rate=0.99 LIMIT 1;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/3da9a46a-7c6e-48b3-9fb6-51ecac1866e7)

4-Film tablosunda bulunan filmlerin uzunluğu 150 dakikadan büyük olanlarına ait kaç farklı replacement_cost değeri vardır?


```sql
SELECT COUNT(DISTINCT replacement_cost) FROM film WHERE film.length>150 ;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/93aba6a5-ac5e-4ee5-ad6d-97b0e24c8023)

---

## Kullanılan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabanı](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
