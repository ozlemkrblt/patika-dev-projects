--country tablosunda bulunan country s�tunundaki �lke isimlerinden 'A' karakteri  ile ba�lay�p 'a' karakteri ile sonlananlar� s�ralay�n�z.

SELECT country FROM Country WHERE country LIKE 'A%a';

--country tablosunda bulunan country s�tunundaki �lke isimlerinden en az 6 karakterden olu�an ve sonu 'n' karakteri ile sonlananlar� s�ralay�n�z.
SELECT country FROM Country WHERE country LIKE '_____%n';


--film tablosunda bulunan title s�tunundaki film isimlerinden en az 4 adet b�y�k ya da k���k harf farketmesizin 'T' karakteri i�eren film isimlerini s�ralay�n�z.
SELECT title FROM film WHERE title ILIKE '%t%t%t%t%';

--film tablosunda bulunan t�m s�tunlardaki verilerden title 'C' karakteri  ile ba�layan ve uzunlu�u (length) 90 dan b�y�k olan ve rental_rate 2.99  olan verileri s�ralay�n�z.
SELECT title,length,rental_rate FROM film WHERE title LIKE 'C%' AND length >90 AND rental_rate = 2.99 ;