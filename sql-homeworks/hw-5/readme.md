# SQL ÇALIÞMASI ÖDEV-5
---
## Ýstenilen : 

Aþaðýdaki sorgu senaryolarýný dvdrental örnek veri tabaný üzerinden gerçekleþtiriniz:

1- Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sýralayýnýz.

```sql
SELECT title,film.length FROM film WHERE title LIKE '%n' ORDER BY film.length DESC LIMIT 5;
```

**Çýktý:**


2-Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en kýsa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) sýralayýnýz.

```sql
SELECT title,film.length FROM film WHERE title LIKE '%n' ORDER BY film.length LIMIT 5 OFFSET 5;
```

**Çýktý:**


3-Customer tablosunda bulunan last_name sütununa göre azalan yapýlan sýralamada store_id 1 olmak koþuluyla ilk 4 veriyi sýralayýnýz. ( IN operatörünü kullanýnýz.)


```sql
SELECT * FROM customer WHERE store_id=1 ORDER BY last_name DESC LIMIT 4;
```

**Çýktý:**


---

## Kullanýlan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabaný](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
