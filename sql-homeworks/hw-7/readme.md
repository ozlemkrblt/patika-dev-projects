# SQL ÇALIÞMASI ÖDEV-7
---
## Ýstenilen : 

Aþaðýdaki sorgu senaryolarýný dvdrental örnek veri tabaný üzerinden gerçekleþtiriniz:

1- Film tablosunda bulunan filmleri rating deðerlerine göre gruplayýnýz.


```sql
SELECT rating FROM film GROUP BY rating;
```

**Çýktý:**


2-Film tablosunda bulunan filmleri replacement_cost sütununa göre grupladýðýmýzda film sayýsý 50 den fazla olan replacement_cost deðerini ve karþýlýk gelen film sayýsýný sýralayýnýz.

```sql
SELECT replacement_cost,COUNT(title) FROM film GROUP BY replacement_cost HAVING COUNT(title) > 50 ORDER BY COUNT(title);
```

**Çýktý:**


3-Customer tablosunda bulunan store_id deðerlerine karþýlýk gelen müþteri sayýlarýný nelerdir? 4. city tablosunda bulunan þehir verilerini country_id sütununa göre gruplandýrdýktan sonra en fazla þehir sayýsý barýndýran country_id bilgisini ve þehir sayýsýný paylaþýnýz.


```sql
SELECT store_id,COUNT(customer_id) FROM customer GROUP BY store_id ORDER BY COUNT(customer_id) DESC;
```

**Çýktý:**

4-City tablosunda bulunan þehir verilerini country_id sütununa göre gruplandýrdýktan sonra en fazla þehir sayýsý barýndýran country_id bilgisini ve þehir sayýsýný paylaþýnýz.

```sql
SELECT country_id,COUNT(*) FROM city GROUP BY country_id ORDER BY COUNT(*) desc LIMIT 1;

```
**Çýktý:**



---

## Kullanýlan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabaný](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
