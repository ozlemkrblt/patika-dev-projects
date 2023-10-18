# SQL ÇALIÞMASI ÖDEV-12
---
## Ýstenilen : 

Aþaðýdaki sorgu senaryolarýný dvdrental örnek veri tabaný üzerinden gerçekleþtiriniz:

1- Film tablosunda film uzunluðu length sütununda gösterilmektedir. Uzunluðu ortalama film uzunluðundan fazla kaç tane film vardýr?


```sql
SELECT COUNT(*) FROM film WHERE film.length > (SELECT AVG(film.length) FROM film);
```

**Çýktý:**



2- Film tablosunda en yüksek rental_rate deðerine sahip kaç tane film vardýr?

```sql
SELECT COUNT(*) FROM film WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);
```

**Çýktý:**



3- Film tablosunda en düþük rental_rate ve en düþün replacement_cost deðerlerine sahip filmleri sýralayýnýz.



```sql
SELECT rental_rate,replacement_cost FROM film WHERE rental_rate = (SELECT MIN(rental_rate) FROM film) AND replacement_cost = (SELECT MIN(replacement_cost) FROM film);
```

**Çýktý:**

4- Payment tablosunda en fazla sayýda alýþveriþ yapan müþterileri(customer) sýralayýnýz.


```sql
SELECT customer_id, COUNT(*) AS total_transactions FROM payment GROUP BY customer_id ORDER BY total_transactions DESC;
```

**Çýktý:**


---

## Kullanýlan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabaný](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
