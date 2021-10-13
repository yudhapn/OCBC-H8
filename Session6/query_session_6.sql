create database db_staff

--b.
create table tb_data_staff(
	nik int primary key,
	nama varchar(50),
	alamat varchar(200),
	handphone varchar(15)
)
--c.
INSERT INTO tb_data_staff(nik, nama, alamat, handphone) VALUES(33760, 'Yudha', 'Malang', '081717161818');
INSERT INTO tb_data_staff(nik, nama, alamat, handphone) VALUES(34760, 'Udin', 'Bekasi', '081818161818');
INSERT INTO tb_data_staff(nik, nama, alamat, handphone) VALUES(35660, 'Dina', 'Bekasi', '082020161818');
INSERT INTO tb_data_staff(nik, nama, alamat, handphone) VALUES(33660, 'Rizal', 'Surabaya', '082123151418');
INSERT INTO tb_data_staff(nik, nama, alamat, handphone) VALUES(23660, 'Gebby', 'Bandung', '082143453428');

--d.
alter table tb_data_staff add joindate date

--e.
INSERT INTO tb_data_staff(nik, nama, alamat, handphone, joindate) VALUES(43260, 'Rakha', 'Malang', '082465450759', '2021-11-11');

--f.
select TOP 2 * from tb_data_staff

--g.
select TOP 3 * from tb_data_staff

--h.
create table tb_staffoutsource (
	nik int primary key,
	nama varchar(50),
	alamat varchar(200),
	handphone varchar(15)
)

alter table tb_staffoutsource add joindate date

--i.
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone) VALUES(33760, 'Yudha', 'Malang', '081717161818');
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone) VALUES(34760, 'Udin', 'Bekasi', '081818161818');
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone) VALUES(35660, 'Dina', 'Bekasi', '082020161818');
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone) VALUES(33660, 'Rizal', 'Surabaya', '082123151418');
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone) VALUES(23660, 'Gebby', 'Bandung', '082143453428');
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone) VALUES(33761, 'Faisal', 'Malang', '081717162121');
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone) VALUES(34762, 'Elvin', 'Bekasi', '081818163232');
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone) VALUES(35663, 'Indah', 'Bekasi', '082020164343');
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone) VALUES(33664, 'Diana', 'Surabaya', '082123154321');
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone) VALUES(23665, 'Setya', 'Bandung', '082143456576');
INSERT INTO tb_staffoutsource(nik, nama, alamat, handphone, joindate) VALUES(45269, 'Lukman', 'Balik Papan', '082487480759', '2021-10-11');

--j
select * from tb_data_staff tds join tb_staffoutsource ts on tds.joindate = ts.joindate

--k
select * from tb_data_staff tds left join tb_staffoutsource ts on tds.joindate = ts.joindate

--l
select * from tb_data_staff tds right join tb_staffoutsource ts on tds.joindate = ts.joindate

--m
select * from tb_data_staff tds inner join tb_staffoutsource ts on tds.joindate = ts.joindate
