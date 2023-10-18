# SQL ÇALIŞMASI ÖDEV-7
---
## İstenilen : 

Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz:

1- Film tablosunda bulunan filmleri rating değerlerine göre gruplayınız.


```sql
SELECT rating FROM film GROUP BY rating;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/6c316c64-6d98-4cfa-8bdf-189f41677955)


2-Film tablosunda bulunan filmleri replacement_cost sütununa göre grupladığımızda film sayısı 50 den fazla olan replacement_cost değerini ve karşılık gelen film sayısını sıralayınız.

```sql
SELECT replacement_cost,COUNT(title) FROM film GROUP BY replacement_cost HAVING COUNT(title) > 50 ORDER BY COUNT(title);
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/e8bc13e8-7f2b-424d-98d9-1ba9c31e0c85)


3-Customer tablosunda bulunan store_id değerlerine karşılık gelen müşteri sayılarını nelerdir? 4. city tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşınız.


```sql
SELECT store_id,COUNT(customer_id) FROM customer GROUP BY store_id ORDER BY COUNT(customer_id) DESC;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/bcf2e486-4eea-47af-942e-4e17debc3b69)

4-City tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşınız.

```sql
SELECT country_id,COUNT(*) FROM city GROUP BY country_id ORDER BY COUNT(*) desc LIMIT 1;

```
**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/187b9a9a-8df1-43aa-b5b3-c876b2831dbb)



---

## Kullanılan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabanı](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
