# SQL ÇALIÞMASI ÖDEV-9
---
## Ýstenilen : 

Aþaðýdaki sorgu senaryolarýný dvdrental örnek veri tabaný üzerinden gerçekleþtiriniz:

1- City tablosu ile country tablosunda bulunan þehir (city) ve ülke (country) isimlerini birlikte görebileceðimiz INNER JOIN sorgusunu yazýnýz.


```sql
SELECT city,country FROM City INNER JOIN Country ON city.country_id = country.country_id;
```

**Çýktý:**



2-Customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceðimiz INNER JOIN sorgusunu yazýnýz.

```sql
SELECT customer.customer_id,customer.first_name,customer.last_name,payment.amount,payment.payment_date FROM Payment INNER JOIN Customer ON customer.customer_id= payment.customer_id;
```

**Çýktý:**



3-Customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceðimiz INNER JOIN sorgusunu yazýnýz.


```sql
SELECT rental.rental_id,customer.customer_id,customer.first_name,customer.last_name FROM Rental INNER JOIN Customer ON customer.customer_id= rental.customer_id;
```

**Çýktý:**


---

## Kullanýlan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabaný](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
