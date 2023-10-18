# SQL ÇALIÞMASI ÖDEV-11
---
## Ýstenilen : 

Aþaðýdaki sorgu senaryolarýný dvdrental örnek veri tabaný üzerinden gerçekleþtiriniz:

1- Actor ve customer tablolarýnda bulunan first_name sütunlarý için tüm verileri sýralayalým.


```sql
SELECT first_name FROM actor UNION SELECT first_name FROM customer;
```

**Çýktý:**



2- Actor ve customer tablolarýnda bulunan first_name sütunlarý için kesiþen verileri sýralayalým.

```sql
SELECT first_name FROM actor INTERSECT SELECT first_name FROM customer;
```

**Çýktý:**



3- Actor ve customer tablolarýnda bulunan first_name sütunlarý için ilk  tabloda bulunan ancak ikinci tabloda bulunmayan verileri sýralayalým.



```sql
SELECT first_name FROM actor EXCEPT ALL SELECT first_name FROM customer;
```

**Çýktý:**


---

## Kullanýlan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabaný](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
