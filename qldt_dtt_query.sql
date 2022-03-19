CREATE DATABASE QUANLYDIENTHOAI_DTT
GO
USE QUANLYDIENTHOAI_DTT

CREATE TABLE HANGSX(
MaHang nchar(10) primary key,
TenHang nvarchar(50))

CREATE TABLE DIENTHOAI(
Ma nchar(20) primary key,
TenDT nvarchar(50),
DonGia float,
TonKho int, 
MaHang nchar(10))

ALTER TABLE DIENTHOAI ADD CONSTRAINT FK_MAH FOREIGN KEY (MaHang) REFERENCES HANGSX(MaHang)

INSERT INTO HANGSX(MaHang, TenHang) VALUES
('NK', 'Nokia'),
('SS', 'Samsung'),
('AP', 'Apple');

INSERT INTO DIENTHOAI(Ma, TenDT, DonGia, TonKho, MaHang) VALUES
('AP_IP7', 'Iphone 7', 4000000, 100, 'AP'),
('AP_IP7P', 'Iphone 7 Plus', 6000000, 62, 'AP'),
('AP_IP8', 'Iphone 8', 5000000, 56, 'AP'),
('AP_IP8P', 'Iphone 8 Plus', 7000000, 75, 'AP'),
('AP_IPX', 'Iphone X', 12000000, 120, 'AP'),
('AP_IP11', 'Iphone 11', 15000000, 91, 'AP'),
('AP_IP12', 'Iphone 12', 18000000, 61, 'AP'),
('AP_IP13', 'Iphone 13', 20000000, 57, 'AP'),
('SS_SS21', 'Samsung S21', 20000000, 50, 'SS'),
('SS_SS22U', 'Samsung S22 Ultra', 22000000, 10, 'SS'),
('SS_SSGS22', 'Samsung Galaxy S22', 19000000, 42, 'SS'),
('SS_SSGA20', 'Samsung Galaxy A20', 20000000, 50, 'SS'),
('NK_NKG10', 'Nokia G10', 3000000, 104, 'NK'),
('NK_NK106', 'Nokia 106', 269000, 29, 'NK'),
('NK_NKC30', 'Nokia C30', 3450000, 15, 'NK'),
('NK_NKC20', 'Nokia C20', 2490000, 63, 'NK'),
('NK_NK215_4G', 'Nokia 215 4G', 900000, 41, 'NK');

