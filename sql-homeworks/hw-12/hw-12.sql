--film tablosunda film uzunluðu length sütununda gösterilmektedir. Uzunluðu ortalama film uzunluðundan fazla kaç tane film vardýr?
SELECT COUNT(*) FROM film WHERE film.length > (SELECT AVG(film.length) FROM film);

--film tablosunda en yüksek rental_rate deðerine sahip kaç tane film vardýr?
SELECT COUNT(*) FROM film WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);

--film tablosunda en düþük rental_rate ve en düþün replacement_cost deðerlerine sahip filmleri sýralayýnýz.
SELECT rental_rate,replacement_cost FROM film WHERE rental_rate = (SELECT MIN(rental_rate) FROM film) AND replacement_cost = (SELECT MIN(replacement_cost) FROM film);


--payment tablosunda en fazla sayýda alýþveriþ yapan müþterileri(customer) sýralayýnýz.
SELECT customer_id, COUNT(*) AS total_transactions FROM payment GROUP BY customer_id ORDER BY total_transactions DESC;