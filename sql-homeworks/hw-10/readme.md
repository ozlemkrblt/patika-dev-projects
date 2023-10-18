


# SQL ÇALIŞMASI ÖDEV-10
---
## İstenilen : 

Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz:

1- City tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.


```sql
SELECT city, country FROM City LEFT JOIN Country ON city.country_id=country.country_id;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/23d3bd06-4bd5-4bbe-bf38-5af13dae9ded)



2-Customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.


```sql
SELECT customer.first_name,  customer.last_name, payment_id 
FROM Payment RIGHT JOIN Customer ON payment.customer_id = customer.customer_id;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/0d423ba4-6bb6-4987-a66f-8e98ce409cbe)



3-Customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.



```sql
SELECT customer.first_name,  customer.last_name, rental_id 
FROM Rental FULL JOIN Customer ON rental.customer_id = customer.customer_id;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/dfacaa58-1409-4211-a5e7-9e7236a747cd)


---

## Kullanılan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabanı](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
