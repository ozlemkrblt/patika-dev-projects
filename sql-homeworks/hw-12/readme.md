# SQL �ALI�MASI �DEV-12
---
## �stenilen : 

A�a��daki sorgu senaryolar�n� dvdrental �rnek veri taban� �zerinden ger�ekle�tiriniz:

1- Film tablosunda film uzunlu�u length s�tununda g�sterilmektedir. Uzunlu�u ortalama film uzunlu�undan fazla ka� tane film vard�r?


```sql
SELECT COUNT(*) FROM film WHERE film.length > (SELECT AVG(film.length) FROM film);
```

**��kt�:**



2- Film tablosunda en y�ksek rental_rate de�erine sahip ka� tane film vard�r?

```sql
SELECT COUNT(*) FROM film WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);
```

**��kt�:**



3- Film tablosunda en d���k rental_rate ve en d���n replacement_cost de�erlerine sahip filmleri s�ralay�n�z.



```sql
SELECT rental_rate,replacement_cost FROM film WHERE rental_rate = (SELECT MIN(rental_rate) FROM film) AND replacement_cost = (SELECT MIN(replacement_cost) FROM film);
```

**��kt�:**

4- Payment tablosunda en fazla say�da al��veri� yapan m��terileri(customer) s�ralay�n�z.


```sql
SELECT customer_id, COUNT(*) AS total_transactions FROM payment GROUP BY customer_id ORDER BY total_transactions DESC;
```

**��kt�:**


---

## Kullan�lan Teknolojiler:

-  Postgresql
- [**dvdrental** �rnek veritaban�](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
