


# SQL �ALI�MASI �DEV-10
---
## �stenilen : 

A�a��daki sorgu senaryolar�n� dvdrental �rnek veri taban� �zerinden ger�ekle�tiriniz:

1- City tablosu ile country tablosunda bulunan �ehir (city) ve �lke (country) isimlerini birlikte g�rebilece�imiz LEFT JOIN sorgusunu yaz�n�z.


```sql
SELECT city, country FROM City LEFT JOIN Country ON city.country_id=country.country_id;
```

**��kt�:**



2-Customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte g�rebilece�imiz RIGHT JOIN sorgusunu yaz�n�z.


```sql
SELECT customer.first_name,  customer.last_name, payment_id 
FROM Payment RIGHT JOIN Customer ON payment.customer_id = customer.customer_id;
```

**��kt�:**



3-Customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte g�rebilece�imiz FULL JOIN sorgusunu yaz�n�z.



```sql
SELECT customer.first_name,  customer.last_name, rental_id 
FROM Rental FULL JOIN Customer ON rental.customer_id = customer.customer_id;
```

**��kt�:**


---

## Kullan�lan Teknolojiler:

-  Postgresql
- [**dvdrental** �rnek veritaban�](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
