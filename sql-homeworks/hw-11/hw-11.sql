--actor ve customer tablolarýnda bulunan first_name sütunlarý için tüm verileri sýralayalým.

SELECT first_name FROM actor UNION SELECT first_name FROM customer;

--actor ve customer tablolarýnda bulunan first_name sütunlarý için kesiþen verileri sýralayalým.

SELECT first_name FROM actor INTERSECT SELECT first_name FROM customer;

--actor ve customer tablolarýnda bulunan first_name sütunlarý için ilk  tabloda bulunan ancak ikinci tabloda bulunmayan verileri sýralayalým.

SELECT first_name FROM actor EXCEPT ALL SELECT first_name FROM customer;