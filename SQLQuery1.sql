

create table _User
(
	username varchar(250) not null,
	password varchar(250) not null
)
--ma hóa
insert into _User(username,password) values('pctrung', ENCRYPTBYPASSPHRASE('aaa','123'))
insert into _User(username,password) values('pctrung2', ENCRYPTBYPASSPHRASE('aaa','456'))

select * from _User
--mở mã hóa
select username, convert(varchar(100),DECRYPTBYPASSPHRASE('aaa',password))as matkhau from _User

select username from _User where convert(varchar(100),DECRYPTBYPASSPHRASE('aaa',password))='123' and username = 'pctrung'