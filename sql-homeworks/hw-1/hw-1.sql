--film tablosunda bulunan title ve description sütunlarýndaki verileri sýralayýnýz.

SELECT title,description FROM Film;

--film tablosunda bulunan tüm sütunlardaki verileri film uzunluðu (length) 60 dan büyük VE 75 ten küçük olma koþullarýyla sýralayýnýz.

SELECT title,length FROM Film WHERE film.length BETWEEN 60 AND 75 ORDER BY length;

--film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99 VE replacement_cost 12.99 VEYA 28.99 olma koþullarýyla sýralayýnýz.


SELECT title,rental_rate,replacement_cost FROM Film WHERE rental_rate= 0.99 AND replacement_cost IN (12.99,28.99);


--customer tablosunda bulunan first_name sütunundaki deðeri 'Mary' olan müþterinin last_name sütunundaki deðeri nedir?

SELECT first_name,last_name FROM Customer WHERE first_name='Mary';

--film tablosundaki uzunluðu(length) 50 ten büyük OLMAYIP ayný zamanda rental_rate deðeri 2.99 veya 4.99 OLMAYAN verileri sýralayýnýz.

SELECT title,length,rental_rate FROM Film WHERE length <50 AND rental_rate NOT IN (2.99,4.99);
