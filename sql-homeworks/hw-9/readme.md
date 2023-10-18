# SQL ÇALIŞMASI ÖDEV-9
---
## İstenilen : 

Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz:

1- City tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.


```sql
SELECT city,country FROM City INNER JOIN Country ON city.country_id = country.country_id;
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/20b804e4-7196-4e99-915c-c2ee5d378267)


2-Customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

```sql
SELECT customer.customer_id,customer.first_name,customer.last_name,payment.amount,payment.payment_date FROM Payment INNER JOIN Customer ON customer.customer_id= payment.customer_id;
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/e74b3eb7-ce8a-421b-b4b1-3c311cf4491c)


3-Customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.


```sql
SELECT rental.rental_id,customer.customer_id,customer.first_name,customer.last_name FROM Rental INNER JOIN Customer ON customer.customer_id= rental.customer_id;
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/7a99d3c0-a531-401b-9016-fa3f91499a38)


---

## Kullanılan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabanı](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
