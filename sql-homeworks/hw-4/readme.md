# SQL ÇALIÞMASI ÖDEV-4
---
## Ýstenilen : 

Aþaðýdaki sorgu senaryolarýný dvdrental örnek veri tabaný üzerinden gerçekleþtiriniz.

1- Film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklý deðerleri sýralayýnýz.
```sql
SELECT DISTINCT replacement_cost FROM film;
```

**Çýktý:**

2- Film tablosunda bulunan replacement_cost sütununda birbirinden farklý kaç tane veri vardýr?
```sql
SELECT (COUNT(DISTINCT replacement_cost)) FROM film;
```

**Çýktý:**


3- Film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile baþlar ve ayný zamanda rating 'G' ye eþittir?
```sql
SELECT (COUNT(title)) FROM film WHERE title LIKE 'T%' AND rating = 'G' ;
```

**Çýktý:**

4- Country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluþmaktadýr?
```sql
SELECT (COUNT(country)) FROM Country WHERE country LIKE '_____';
```

**Çýktý:**


5- City tablosundaki þehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?
```sql
SELECT (COUNT(city)) FROM City WHERE city ILIKE '%R';
```

**Çýktý:**



---

## Kullanýlan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabaný](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 

