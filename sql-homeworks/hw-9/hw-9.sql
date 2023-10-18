
--city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte  görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT city,country FROM City INNER JOIN Country ON city.country_id = country.country_id;

--customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

SELECT customer.customer_id,customer.first_name,customer.last_name,payment.amount,payment.payment_date FROM Payment INNER JOIN Customer ON customer.customer_id= payment.customer_id;


--customer tablosu ile rental tablosunda bulunan rental_id  ile customer tablosundaki first_name ve last_name  isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

SELECT rental.rental_id,customer.customer_id,customer.first_name,customer.last_name FROM Rental INNER JOIN Customer ON customer.customer_id= rental.customer_id;
