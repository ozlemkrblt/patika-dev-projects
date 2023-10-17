# SQL ÇALIŞMASI ÖDEV-3
---
## İstenilen : 

Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz:

1- Country tablosunda bulunan country sütunundaki ülke isimlerinden 'A' karakteri ile başlayıp 'a' karakteri ile sonlananları sıralayınız.

```sql
SELECT country FROM Country WHERE country LIKE 'A%a';
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/ac25b5cc-c150-459d-a124-1f61af33539f)


2-Country tablosunda bulunan country sütunundaki ülke isimlerinden en az 6 karakterden oluşan ve sonu 'n' karakteri ile sonlananları sıralayınız.

```sql
SELECT country FROM Country WHERE country LIKE '_____%n';
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/e4012814-4be1-4029-b872-e0b979dedfe1)


3-Film tablosunda bulunan title sütunundaki film isimlerinden en az 4 adet büyük ya da küçük harf farketmesizin 'T' karakteri içeren film isimlerini sıralayınız.

```sql
SELECT title FROM film WHERE title ILIKE '%t%t%t%t%';
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/cef2ad24-70a6-4b3d-b992-246a795f8bc0)


4-Film tablosunda bulunan tüm sütunlardaki verilerden title 'C' karakteri ile başlayan ve uzunluğu (length) 90 dan büyük olan ve rental_rate 2.99 olan verileri sıralayınız.

```sql
SELECT title,length,rental_rate FROM film WHERE title LIKE 'C%' AND length >90 AND rental_rate = 2.99 ;
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/83190280-bd1b-4baa-b4cd-b0a9b6ac0172)

---

## Kullanılan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabanı](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
