# SQL ÇALIŞMASI ÖDEV-5
---
## İstenilen : 

Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz:

1- Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sıralayınız.

```sql
SELECT title,film.length FROM film WHERE title LIKE '%n' ORDER BY film.length DESC LIMIT 5;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/6f828dc6-12cb-4c17-811e-97fa5d9ce91d)


2-Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en kısa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) sıralayınız.

```sql
SELECT title,film.length FROM film WHERE title LIKE '%n' ORDER BY film.length LIMIT 5 OFFSET 5;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/edb37fa0-d4f6-40b7-a5c7-b9c9e9b9a6bf)


3-Customer tablosunda bulunan last_name sütununa göre azalan yapılan sıralamada store_id 1 olmak koşuluyla ilk 4 veriyi sıralayınız. ( IN operatörünü kullanınız.)


```sql
SELECT * FROM customer WHERE store_id=1 ORDER BY last_name DESC LIMIT 4;
```

**Çıktı:**
![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/48ef084e-987e-4a81-8ebe-9d850fc6c1fb)


---

## Kullanılan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabanı](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
