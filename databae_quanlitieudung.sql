
create database quanLyTieuDung
go
use quanLyTieuDung
go

create table phong(
	id INT IDENTITY(1,1) PRIMARY KEY,
	t_phong nvarchar(100) not null,
	h_muc int not null
);

CREATE TABLE nguoi_dung (
	id INT IDENTITY(1,1) PRIMARY KEY,
    t_khoan VARCHAR(50) NOT NULL ,
    m_khau VARCHAR(50) NOT NULL,
    tn_dung nvarchar(50) not null,
	que_quan nvarchar(100) not null,
	ngay_lam date not null,
    c_vu nvarchar(20),
	id_phong int foreign key references phong(id),
	g_tinh bit not null
);

create table loai_tieu_dung(
	id INT IDENTITY(1,1) PRIMARY KEY,
	l_tdung nvarchar(50) not null
);

create table trang_thai(
	id INT IDENTITY(1,1) PRIMARY KEY,
	t_tthai nvarchar(50) not null
);

create table tieu_dung(
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_nguoidung int foreign key references nguoi_dung(id) not null,
	t_tdung nvarchar(100) not null,
	gia int not null,
	ngay_de_nghi date not null,
	ngay_duyet date,
	ngay_giao_tien date,
	ngay_hoan_thanh date,
	id_tdung int foreign key references loai_tieu_dung(id),
	t_thai int foreign key references trang_thai(id),
	ghi_chu nvarchar(500),
	id_ktoan int foreign key references nguoi_dung(id),
	id_qly int foreign key references nguoi_dung(id),
);
drop database quanLyTieuDung

--them du lieu test
insert into phong(t_phong, h_muc) values (N'Phòng kế toán', 30000000), (N'Phòng kỹ thuật', 20000000);
insert into loai_tieu_dung(l_tdung) values (N'Nâng cấp'), (N'Mua mới'), (N'bảo trì');
insert into nguoi_dung(tn_dung, t_khoan, m_khau, que_quan, ngay_lam, c_vu, id_phong,g_tinh) values (N'Trần Ngọc Thăng','thang','1',N'Thái Bình', GETDATE(), N'Nhân viên', '1',1), (N'Chung thanh huy','huy','1',N'Thái Bình', GETDATE(), N'Nhân viên', '2',1), (N'Ngô Thị Thu Bơ','bo','1',N'Thái Bình', GETDATE(), N'Kế toán', '2',0);
insert into nguoi_dung(tn_dung, t_khoan, m_khau, que_quan, ngay_lam, c_vu, id_phong,g_tinh) values (N'Admin','admin','admin',N'Thái Bình', GETDATE(), N'Quản lý', '1',1)
insert into trang_thai(t_tthai) values (N'Khởi tạo'),(N'Chấp nhận'),(N'Từ chối'),(N'Đã nhận tiền'),(N'Nghiệp thu'),(N'Hoàn tiền');
insert into tieu_dung(id_nguoidung, t_tdung, gia, ngay_de_nghi, id_tdung, t_thai) values (1, N'Mua máy', 1000000, GETDATE(), 1,1), (2,N'Mua chuot', 3000000, GETDATE(), 2,1), (1,N'server', 100000, GETDATE(), 3,1), (2,N'Mua chuot', 10000000, GETDATE(), 3,1), (1,N'Mua chuot', 5000000, GETDATE(), 1, 1), (1,N'Mua chuot', 1000000, GETDATE(), 1,1);
insert into tieu_dung(id_nguoidung, t_tdung, gia, ngay_de_nghi, id_tdung, t_thai) values (3, N'Mua máy', 1000000, GETDATE(), 1,2), (2,N'Mua chuot', 3000000, GETDATE(), 2,2), (1,N'server', 100000, GETDATE(), 3,2), (2,N'Mua chuot', 10000000, GETDATE(), 3,2), (1,N'Mua chuot', 5000000, GETDATE(), 1, 2), (1,N'Mua chuot', 1000000, GETDATE(), 1,2);

--create view
CREATE VIEW viewThongKe
AS
select tieu_dung.id, tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Nhu Cầu',t_phong as 'Phòng', loai_tieu_dung.l_tdung as 'Loại tiêu dùng', gia as 'Giá', ngay_de_nghi as 'Đề nghị',ngay_giao_tien as 'Giao tiền', ngay_hoan_thanh as 'Hoàn thành', 'Kế toán' = (select tn_dung from nguoi_dung where id = tieu_dung.id_ktoan), t_tthai as 'Trạng thái', phong.h_muc as 'Hạn mức'
from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong 
where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id

create view viewPhong
as
select phong.id, phong.t_phong as 'Tên phòng','Số lượng nhân viên' = (select count(id) from nguoi_dung where nguoi_dung.id_phong = phong.id), phong.h_muc as 'Hạn mức'
from phong

--view thong ke chi theo ngay()con thieu ngay
create view THONGKE as
select nguoi_dung.tn_dung as 'Nhân viên', t_tdung as 'Tiêu dùng', gia as 'Giá', trang_thai.t_tthai as 'Trạng thái', phong.t_phong, tieu_dung.t_thai, phong.id as id_phong, 'Kế toán' = (select tn_dung from nguoi_dung where id = tieu_dung.id_ktoan), CONVERT(date, tieu_dung.ngay_de_nghi, 103) as 'ngay_de_nghi',CONVERT(date, tieu_dung.ngay_duyet, 103) as 'ngay_duyet',CONVERT(date, tieu_dung.ngay_giao_tien, 103) as 'ngay_giao_tien',CONVERT(date, tieu_dung.ngay_hoan_thanh, 103) as 'ngay_hoan_thanh', phong.h_muc
from tieu_dung, nguoi_dung, trang_thai,phong  
where tieu_dung.id_nguoidung = nguoi_dung.id and trang_thai.id = tieu_dung.t_thai and phong.id = nguoi_dung.id_phong

create view CHITIETTIEUDUNG as
select tieu_dung.t_tdung, 'Kế toán' = (select tn_dung from nguoi_dung where id = tieu_dung.id_ktoan), 'Quản lý' = (select tn_dung from nguoi_dung where id = tieu_dung.id_qly), tieu_dung.ngay_de_nghi, tieu_dung.ngay_duyet, tieu_dung.ngay_giao_tien, tieu_dung.ngay_hoan_thanh, thang = FORMAT (tieu_dung.ngay_de_nghi, 'MM') from tieu_dung, nguoi_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and trang_thai.id = tieu_dung.t_thai and phong.id = nguoi_dung.id_phong and ngay_giao_tien is not null and FORMAT (tieu_dung.ngay_de_nghi, 'MM')=01

--lệnh test
select * from CHITIETTIEUDUNG
select * from nguoi_dung where t_khoan ='d' and m_khau='a'
select * from nguoi_dung where t_khoan ='thang' and m_khau='1';
select tn_dung as'Tên người dùng', t_phong as 'Tên phòng', t_tdung as 'Sử dụng', gia as 'Giá', ngay as 'Ngày', t_thai as 'Trạng thái'  from nguoi_dung, tieu_dung, phong  where tieu_dung.id_nguoidung = nguoi_dung.id and phong.id=nguoi_dung.id_phong and phong.id=0;
select phong.h_muc,tieu_dung.gia from nguoi_dung, tieu_dung, phong where nguoi_dung.id_phong = phong.id and tieu_dung.id_nguoidung = nguoi_dung.id and phong.id=1;
select phong.t_phong, phong.h_muc, sum(tieu_dung.gia) as tong from nguoi_dung, tieu_dung, phong where nguoi_dung.id_phong = phong.id and tieu_dung.id_nguoidung = nguoi_dung.id and phong.id=2 GROUP BY phong.t_phong, phong.h_muc
select nguoi_dung.tn_dung, sum(tieu_dung.gia) as tong from nguoi_dung, tieu_dung, phong where nguoi_dung.id_phong = phong.id and tieu_dung.id_nguoidung = nguoi_dung.id and id_nguoidung=2 GROUP BY nguoi_dung.tn_dung

select tieu_dung.id, loai_tieu_dung.id, t_tdung as 'Mô tả', loai_tieu_dung.l_tdung, gia as 'Giá', ngay as 'Ngày lập', t_thai as 'Trạng thái' from tieu_dung, loai_tieu_dung where tieu_dung.id_tdung=loai_tieu_dung.id and tieu_dung.id_nguoidung=1

select tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Nhu Cầu',t_phong as 'Phòng', t_tdung as 'Loại tiêu dùng', gia as 'Giá', ngay_de_nghi as 'Đề nghị', ngay_hoan_thanh as 'Hoàn thanh', t_tthai as 'Trạng thái', tieu_dung.id from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id 
select * from nguoi_dung, phong where phong.id = nguoi_dung.id_phong

select t_khoan as 'Tài khoản', m_khau as 'Mật khẩu', tn_dung as 'Nhân viên', que_quan as 'Quê quán', ngay_lam as 'Ngày làm', c_vu as 'Chức vụ', phong.t_phong  from nguoi_dung, phong where phong.id = nguoi_dung.id_phong and id_phong = 
select  tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Mua', gia as 'Giá', loai_tieu_dung.l_tdung as 'Phân lo?i', ngay_de_nghi as 'Ð? ngh?', ngay_hoan_thanh as 'Giao ti?n', t_tthai as 'Tr?ng thái', tieu_dung.id from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id and id_phong = 2 and t_thai = 1

select * from viewThongKe 
select * from viewPhong
select * from tieu_dung
select  tn_dung as 'Nhân viên',tieu_dung.t_tdung as 'Mua', gia as 'Giá', loai_tieu_dung.l_tdung as 'Phân lo?i', ngay_de_nghi as 'Ð? ngh?', ngay_hoan_thanh as 'Giao ti?n', t_tthai as 'Tr?ng thái', tieu_dung.id from tieu_dung, nguoi_dung, loai_tieu_dung, trang_thai, phong where tieu_dung.id_nguoidung = nguoi_dung.id and tieu_dung.id_tdung = loai_tieu_dung.id and tieu_dung.t_thai = trang_thai.id and nguoi_dung.id_phong = phong.id and id_phong = 1 and (t_thai =1 or t_thai=2 or t_thai=3 )
select * from tieu_dung where id_nguoidung in (select id from nguoi_dung where id_phong=2) and (t_thai =1 or t_thai=2 or t_thai=3 )
select * from tieu_dung where id_nguoidung in (select id from nguoi_dung where id_phong=2) and (t_thai =1 or t_thai=2 or t_thai=3 )

select phong.id, phong.t_phong as 'Tên phòng', count(id_phong) as 'Số lượng nhân viên', phong.h_muc as 'Hạn mức' 
from nguoi_dung, phong 
where phong.id = nguoi_dung.id_phong 
group by id_phong, phong.t_phong, h_muc,phong.id

select * from phong ORDER BY id DESC;
select * from tieu_dung
delete nguoi_dung where id=4


