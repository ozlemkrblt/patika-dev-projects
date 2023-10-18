

--city tablosu ile country tablosunda bulunan þehir (city) ve ülke (country) isimlerini  birlikte görebileceðimiz LEFT JOIN sorgusunu yazýnýz.

SELECT city, country FROM City LEFT JOIN Country ON city.country_id=country.country_id;
--customer tablosu ile payment tablosunda bulunan payment_id  ile customer tablosundaki  first_name ve last_name isimlerini birlikte görebileceðimiz RIGHT JOIN sorgusunu yazýnýz.

SELECT customer.first_name,  customer.last_name, payment_id 
FROM Payment RIGHT JOIN Customer ON payment.customer_id = customer.customer_id;

--customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name  ve last_name isimlerini birlikte görebileceðimiz FULL JOIN sorgusunu yazýnýz.

SELECT customer.first_name,  customer.last_name, rental_id 
FROM Rental FULL JOIN Customer ON rental.customer_id = customer.customer_id;