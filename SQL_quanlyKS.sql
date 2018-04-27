create database QuanlyKS
use QuanlyKS
go
create table account
(
	username nvarchar(20),
	password varchar(20),
	primary key(username)
)

create table dichvu
(
	maDV  varchar(10),
	tenDV nvarchar(20),
	giaDV float
	primary key(maDV)
)

create table Phong
(
	maPh varchar(10),
	loai varchar(10),
	donGia float,
	soGiuong int,
	tinhTrang varchar(10)
	primary key (maPh)
)

create table NhanVien
(
	maNV varchar(10),
	tenNV varchar(25),
	gioiTinh varchar(5),
	ngaySinh date,
	cmnd varchar(15),
	sdt varchar(11),
	chucVu varchar(10),
	diaChi varchar(255),
	luong float,
	timeLam  date,
	timeNghi date
	primary key (maNV)
	
)

create table ThuePhong
(
	maTPh varchar(10),
	maPh varchar(10),
	tenThue varchar(25),
	cmnd varchar(15),
	sdt varchar(11),
	timeNPh datetime
	primary key (maTPh)
)

create table DatPhong
(
	maDPh varchar(20),
	maPh varchar(10),
	tenDat varchar(25),
	cmnd varchar(15),
	sdt varchar(11),
	timeDPh datetime,
	tinhtrang varchar(10)
	primary key (maDPh)
)