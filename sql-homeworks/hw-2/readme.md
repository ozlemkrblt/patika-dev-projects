
# SQL ÇALIŞMASI ÖDEV-2
---
## İstenilen : 

Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz:

1- Film tablosunda bulunan tüm sütunlardaki verileri replacement cost değeri 12.99 dan büyük eşit ve 16.99 küçük olma koşuluyla sıralayınız ( BETWEEN - AND yapısını kullanınız.)

```sql
SELECT * FROM Film WHERE replacement_cost BETWEEN 12.99 AND 16.99;
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/0feb4a37-2341-4eb5-9760-5d400f924bf9)


2-Actor tablosunda bulunan first_name ve last_name sütunlardaki verileri first_name 'Penelope' veya 'Nick' veya 'Ed' değerleri olması 
koşuluyla sıralayınız. ( IN operatörünü kullanınız.)

```sql
SELECT first_name,last_name FROM actor WHERE first_name IN ('Penelope','Nick','Ed');
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/b6eae306-f6d7-43c8-ac13-b0574b93f282)


3-Film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99, 2.99, 4.99 VE replacement_cost 12.99, 15.99, 28.99 olma koşullarıyla sıralayınız. ( IN operatörünü kullanınız.)


```sql
SELECT * FROM Film WHERE replacement_cost IN (12.99, 15.99,28.99) AND rental_rate IN (0.99,2.99,4.99) ;
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/de807c52-d787-4909-8ce7-02a9727e7c2e)



---

## Kullanılan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabanı](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
