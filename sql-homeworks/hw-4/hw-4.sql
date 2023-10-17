--film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklý deðerleri sýralayýnýz.

SELECT DISTINCT replacement_cost FROM film;


--film tablosunda bulunan replacement_cost sütununda birbirinden farklý kaç tane veri vardýr?

SELECT (COUNT(DISTINCT replacement_cost)) FROM film;

--film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile baþlar ve ayný zamanda rating 'G' ye eþittir?

SELECT (COUNT(title)) FROM film WHERE title LIKE 'T%' AND rating = 'G' ;

--country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluþmaktadýr?

SELECT (COUNT(country)) FROM Country WHERE country LIKE '_____';


--city tablosundaki þehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?
SELECT (COUNT(city)) FROM City WHERE city ILIKE '%R';