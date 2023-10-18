# SQL ÇALIŞMASI ÖDEV-12
---
## İstenilen : 

Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz:

1- Film tablosunda film uzunluðu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?

```sql
SELECT COUNT(*) FROM film WHERE film.length > (SELECT AVG(film.length) FROM film);
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/341fc475-4617-477c-96ec-6fcdc9573c29)

2- Film tablosunda en yüksek rental_rate deðerine sahip kaç tane film vardýr?

```sql
SELECT COUNT(*) FROM film WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/c534f4e2-c788-4e7c-9e6a-0a0ccf745810)

3- Film tablosunda en düşük rental_rate ve en düþün replacement_cost değerlerine sahip filmleri sıralayınız.

```sql
SELECT rental_rate,replacement_cost FROM film WHERE rental_rate = (SELECT MIN(rental_rate) FROM film) AND replacement_cost = (SELECT MIN(replacement_cost) FROM film);
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/5454aa67-ce32-4f83-a80f-b8c01cc99193)

4- Payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.

```sql
SELECT customer_id, COUNT(*) AS total_transactions FROM payment GROUP BY customer_id ORDER BY total_transactions DESC;
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/8813c617-d056-4d3c-aea0-175322638dad)

---

## Kullanılan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabaný](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
