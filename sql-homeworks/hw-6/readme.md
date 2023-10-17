# SQL �ALI�MASI �DEV-6
---
## �stenilen : 

A�a��daki sorgu senaryolar�n� dvdrental �rnek veri taban� �zerinden ger�ekle�tiriniz:

1- Film tablosunda bulunan rental_rate s�tunundaki de�erlerin ortalamas� nedir?


```sql
SELECT ROUND(AVG(rental_rate),2) FROM film;
```

**��kt�:**


2-Film tablosunda bulunan filmlerden ka� tanesi 'C' karakteri ile ba�lar?

```sql
SELECT COUNT(title) FROM film WHERE title LIKE 'C%';
```

**��kt�:**


3-Film tablosunda bulunan filmlerden rental_rate de�eri 0.99 a e�it olan en uzun (length) film ka� dakikad�r?


```sql
SELECT MAX(length) FROM film WHERE rental_rate=0.99 LIMIT 1;
```

**��kt�:**

4-Film tablosunda bulunan filmlerin uzunlu�u 150 dakikadan b�y�k olanlar�na ait ka� farkl� replacement_cost de�eri vard�r?


```sql
SELECT COUNT(DISTINCT replacement_cost) FROM film WHERE film.length>150 ;
```

**��kt�:**

---

## Kullan�lan Teknolojiler:

-  Postgresql
- [**dvdrental** �rnek veritaban�](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
