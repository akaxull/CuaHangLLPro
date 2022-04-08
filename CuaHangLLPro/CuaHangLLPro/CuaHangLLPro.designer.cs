﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuaHangLLPro
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLCuaHang")]
	public partial class CuaHangLLProDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblChiTietHoaDon(tblChiTietHoaDon instance);
    partial void UpdatetblChiTietHoaDon(tblChiTietHoaDon instance);
    partial void DeletetblChiTietHoaDon(tblChiTietHoaDon instance);
    partial void InserttblHoaDon(tblHoaDon instance);
    partial void UpdatetblHoaDon(tblHoaDon instance);
    partial void DeletetblHoaDon(tblHoaDon instance);
    partial void InserttblKhachHang(tblKhachHang instance);
    partial void UpdatetblKhachHang(tblKhachHang instance);
    partial void DeletetblKhachHang(tblKhachHang instance);
    partial void InserttblSach(tblSach instance);
    partial void UpdatetblSach(tblSach instance);
    partial void DeletetblSach(tblSach instance);
    partial void InserttblTaiKhoan(tblTaiKhoan instance);
    partial void UpdatetblTaiKhoan(tblTaiKhoan instance);
    partial void DeletetblTaiKhoan(tblTaiKhoan instance);
    partial void InserttblNhanVien(tblNhanVien instance);
    partial void UpdatetblNhanVien(tblNhanVien instance);
    partial void DeletetblNhanVien(tblNhanVien instance);
    #endregion
		
		public CuaHangLLProDataContext() : 
				base(global::CuaHangLLPro.Properties.Settings.Default.QLCuaHangConnectionString4, mappingSource)
		{
			OnCreated();
		}
		
		public CuaHangLLProDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CuaHangLLProDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CuaHangLLProDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CuaHangLLProDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblChiTietHoaDon> tblChiTietHoaDons
		{
			get
			{
				return this.GetTable<tblChiTietHoaDon>();
			}
		}
		
		public System.Data.Linq.Table<tblHoaDon> tblHoaDons
		{
			get
			{
				return this.GetTable<tblHoaDon>();
			}
		}
		
		public System.Data.Linq.Table<tblKhachHang> tblKhachHangs
		{
			get
			{
				return this.GetTable<tblKhachHang>();
			}
		}
		
		public System.Data.Linq.Table<tblSach> tblSaches
		{
			get
			{
				return this.GetTable<tblSach>();
			}
		}
		
		public System.Data.Linq.Table<tblTaiKhoan> tblTaiKhoans
		{
			get
			{
				return this.GetTable<tblTaiKhoan>();
			}
		}
		
		public System.Data.Linq.Table<tblNhanVien> tblNhanViens
		{
			get
			{
				return this.GetTable<tblNhanVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblChiTietHoaDon")]
	public partial class tblChiTietHoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHoaDon;
		
		private string _MaSach;
		
		private int _SoLuong;
		
		private EntityRef<tblHoaDon> _tblHoaDon;
		
		private EntityRef<tblSach> _tblSach;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHoaDonChanging(string value);
    partial void OnMaHoaDonChanged();
    partial void OnMaSachChanging(string value);
    partial void OnMaSachChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    #endregion
		
		public tblChiTietHoaDon()
		{
			this._tblHoaDon = default(EntityRef<tblHoaDon>);
			this._tblSach = default(EntityRef<tblSach>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHoaDon", DbType="NChar(19) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHoaDon
		{
			get
			{
				return this._MaHoaDon;
			}
			set
			{
				if ((this._MaHoaDon != value))
				{
					if (this._tblHoaDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHoaDonChanging(value);
					this.SendPropertyChanging();
					this._MaHoaDon = value;
					this.SendPropertyChanged("MaHoaDon");
					this.OnMaHoaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					if (this._tblSach.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblHoaDon_tblChiTietHoaDon", Storage="_tblHoaDon", ThisKey="MaHoaDon", OtherKey="MaHoaDon", IsForeignKey=true)]
		public tblHoaDon tblHoaDon
		{
			get
			{
				return this._tblHoaDon.Entity;
			}
			set
			{
				tblHoaDon previousValue = this._tblHoaDon.Entity;
				if (((previousValue != value) 
							|| (this._tblHoaDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblHoaDon.Entity = null;
						previousValue.tblChiTietHoaDons.Remove(this);
					}
					this._tblHoaDon.Entity = value;
					if ((value != null))
					{
						value.tblChiTietHoaDons.Add(this);
						this._MaHoaDon = value.MaHoaDon;
					}
					else
					{
						this._MaHoaDon = default(string);
					}
					this.SendPropertyChanged("tblHoaDon");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblSach_tblChiTietHoaDon", Storage="_tblSach", ThisKey="MaSach", OtherKey="MaSach", IsForeignKey=true)]
		public tblSach tblSach
		{
			get
			{
				return this._tblSach.Entity;
			}
			set
			{
				tblSach previousValue = this._tblSach.Entity;
				if (((previousValue != value) 
							|| (this._tblSach.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblSach.Entity = null;
						previousValue.tblChiTietHoaDons.Remove(this);
					}
					this._tblSach.Entity = value;
					if ((value != null))
					{
						value.tblChiTietHoaDons.Add(this);
						this._MaSach = value.MaSach;
					}
					else
					{
						this._MaSach = default(string);
					}
					this.SendPropertyChanged("tblSach");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblHoaDon")]
	public partial class tblHoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHoaDon;
		
		private string _MaNhanVien;
		
		private string _MaKhachHang;
		
		private System.DateTime _NgayXuatHoaDon;
		
		private System.Nullable<int> _GiamGia;
		
		private int _TongTien;
		
		private EntitySet<tblChiTietHoaDon> _tblChiTietHoaDons;
		
		private EntityRef<tblKhachHang> _tblKhachHang;
		
		private EntityRef<tblNhanVien> _tblNhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHoaDonChanging(string value);
    partial void OnMaHoaDonChanged();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    partial void OnMaKhachHangChanging(string value);
    partial void OnMaKhachHangChanged();
    partial void OnNgayXuatHoaDonChanging(System.DateTime value);
    partial void OnNgayXuatHoaDonChanged();
    partial void OnGiamGiaChanging(System.Nullable<int> value);
    partial void OnGiamGiaChanged();
    partial void OnTongTienChanging(int value);
    partial void OnTongTienChanged();
    #endregion
		
		public tblHoaDon()
		{
			this._tblChiTietHoaDons = new EntitySet<tblChiTietHoaDon>(new Action<tblChiTietHoaDon>(this.attach_tblChiTietHoaDons), new Action<tblChiTietHoaDon>(this.detach_tblChiTietHoaDons));
			this._tblKhachHang = default(EntityRef<tblKhachHang>);
			this._tblNhanVien = default(EntityRef<tblNhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHoaDon", DbType="NChar(19) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHoaDon
		{
			get
			{
				return this._MaHoaDon;
			}
			set
			{
				if ((this._MaHoaDon != value))
				{
					this.OnMaHoaDonChanging(value);
					this.SendPropertyChanging();
					this._MaHoaDon = value;
					this.SendPropertyChanged("MaHoaDon");
					this.OnMaHoaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					if (this._tblNhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="NChar(10)")]
		public string MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					if (this._tblKhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayXuatHoaDon", DbType="DateTime NOT NULL")]
		public System.DateTime NgayXuatHoaDon
		{
			get
			{
				return this._NgayXuatHoaDon;
			}
			set
			{
				if ((this._NgayXuatHoaDon != value))
				{
					this.OnNgayXuatHoaDonChanging(value);
					this.SendPropertyChanging();
					this._NgayXuatHoaDon = value;
					this.SendPropertyChanged("NgayXuatHoaDon");
					this.OnNgayXuatHoaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiamGia", DbType="Int")]
		public System.Nullable<int> GiamGia
		{
			get
			{
				return this._GiamGia;
			}
			set
			{
				if ((this._GiamGia != value))
				{
					this.OnGiamGiaChanging(value);
					this.SendPropertyChanging();
					this._GiamGia = value;
					this.SendPropertyChanged("GiamGia");
					this.OnGiamGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Int NOT NULL")]
		public int TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblHoaDon_tblChiTietHoaDon", Storage="_tblChiTietHoaDons", ThisKey="MaHoaDon", OtherKey="MaHoaDon")]
		public EntitySet<tblChiTietHoaDon> tblChiTietHoaDons
		{
			get
			{
				return this._tblChiTietHoaDons;
			}
			set
			{
				this._tblChiTietHoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblKhachHang_tblHoaDon", Storage="_tblKhachHang", ThisKey="MaKhachHang", OtherKey="MaKhachHang", IsForeignKey=true)]
		public tblKhachHang tblKhachHang
		{
			get
			{
				return this._tblKhachHang.Entity;
			}
			set
			{
				tblKhachHang previousValue = this._tblKhachHang.Entity;
				if (((previousValue != value) 
							|| (this._tblKhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblKhachHang.Entity = null;
						previousValue.tblHoaDons.Remove(this);
					}
					this._tblKhachHang.Entity = value;
					if ((value != null))
					{
						value.tblHoaDons.Add(this);
						this._MaKhachHang = value.MaKhachHang;
					}
					else
					{
						this._MaKhachHang = default(string);
					}
					this.SendPropertyChanged("tblKhachHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblNhanVien_tblHoaDon", Storage="_tblNhanVien", ThisKey="MaNhanVien", OtherKey="MaNhanVien", IsForeignKey=true)]
		public tblNhanVien tblNhanVien
		{
			get
			{
				return this._tblNhanVien.Entity;
			}
			set
			{
				tblNhanVien previousValue = this._tblNhanVien.Entity;
				if (((previousValue != value) 
							|| (this._tblNhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblNhanVien.Entity = null;
						previousValue.tblHoaDons.Remove(this);
					}
					this._tblNhanVien.Entity = value;
					if ((value != null))
					{
						value.tblHoaDons.Add(this);
						this._MaNhanVien = value.MaNhanVien;
					}
					else
					{
						this._MaNhanVien = default(string);
					}
					this.SendPropertyChanged("tblNhanVien");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblChiTietHoaDons(tblChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.tblHoaDon = this;
		}
		
		private void detach_tblChiTietHoaDons(tblChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.tblHoaDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblKhachHang")]
	public partial class tblKhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhachHang;
		
		private string _TenKhachHang;
		
		private string _Sdt;
		
		private string _GioiTinh;
		
		private EntitySet<tblHoaDon> _tblHoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhachHangChanging(string value);
    partial void OnMaKhachHangChanged();
    partial void OnTenKhachHangChanging(string value);
    partial void OnTenKhachHangChanged();
    partial void OnSdtChanging(string value);
    partial void OnSdtChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    #endregion
		
		public tblKhachHang()
		{
			this._tblHoaDons = new EntitySet<tblHoaDon>(new Action<tblHoaDon>(this.attach_tblHoaDons), new Action<tblHoaDon>(this.detach_tblHoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhachHang", DbType="NVarChar(MAX)")]
		public string TenKhachHang
		{
			get
			{
				return this._TenKhachHang;
			}
			set
			{
				if ((this._TenKhachHang != value))
				{
					this.OnTenKhachHangChanging(value);
					this.SendPropertyChanging();
					this._TenKhachHang = value;
					this.SendPropertyChanged("TenKhachHang");
					this.OnTenKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sdt", DbType="NChar(11)")]
		public string Sdt
		{
			get
			{
				return this._Sdt;
			}
			set
			{
				if ((this._Sdt != value))
				{
					this.OnSdtChanging(value);
					this.SendPropertyChanging();
					this._Sdt = value;
					this.SendPropertyChanged("Sdt");
					this.OnSdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NChar(10)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblKhachHang_tblHoaDon", Storage="_tblHoaDons", ThisKey="MaKhachHang", OtherKey="MaKhachHang")]
		public EntitySet<tblHoaDon> tblHoaDons
		{
			get
			{
				return this._tblHoaDons;
			}
			set
			{
				this._tblHoaDons.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblHoaDons(tblHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.tblKhachHang = this;
		}
		
		private void detach_tblHoaDons(tblHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.tblKhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblSach")]
	public partial class tblSach : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSach;
		
		private string _TenSach;
		
		private string _TheLoai;
		
		private int _GiaTien;
		
		private System.Nullable<int> _GiaNhap;
		
		private int _SoLuong;
		
		private string _NhaXuatBan;
		
		private System.Nullable<int> _NamXuatBan;
		
		private string _TacGia;
		
		private System.Nullable<bool> _TrangThai;
		
		private System.Nullable<int> _GiamGia;
		
		private EntitySet<tblChiTietHoaDon> _tblChiTietHoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSachChanging(string value);
    partial void OnMaSachChanged();
    partial void OnTenSachChanging(string value);
    partial void OnTenSachChanged();
    partial void OnTheLoaiChanging(string value);
    partial void OnTheLoaiChanged();
    partial void OnGiaTienChanging(int value);
    partial void OnGiaTienChanged();
    partial void OnGiaNhapChanging(System.Nullable<int> value);
    partial void OnGiaNhapChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnNhaXuatBanChanging(string value);
    partial void OnNhaXuatBanChanged();
    partial void OnNamXuatBanChanging(System.Nullable<int> value);
    partial void OnNamXuatBanChanged();
    partial void OnTacGiaChanging(string value);
    partial void OnTacGiaChanged();
    partial void OnTrangThaiChanging(System.Nullable<bool> value);
    partial void OnTrangThaiChanged();
    partial void OnGiamGiaChanging(System.Nullable<int> value);
    partial void OnGiamGiaChanged();
    #endregion
		
		public tblSach()
		{
			this._tblChiTietHoaDons = new EntitySet<tblChiTietHoaDon>(new Action<tblChiTietHoaDon>(this.attach_tblChiTietHoaDons), new Action<tblChiTietHoaDon>(this.detach_tblChiTietHoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSach", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenSach
		{
			get
			{
				return this._TenSach;
			}
			set
			{
				if ((this._TenSach != value))
				{
					this.OnTenSachChanging(value);
					this.SendPropertyChanging();
					this._TenSach = value;
					this.SendPropertyChanged("TenSach");
					this.OnTenSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TheLoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TheLoai
		{
			get
			{
				return this._TheLoai;
			}
			set
			{
				if ((this._TheLoai != value))
				{
					this.OnTheLoaiChanging(value);
					this.SendPropertyChanging();
					this._TheLoai = value;
					this.SendPropertyChanged("TheLoai");
					this.OnTheLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaTien", DbType="Int NOT NULL")]
		public int GiaTien
		{
			get
			{
				return this._GiaTien;
			}
			set
			{
				if ((this._GiaTien != value))
				{
					this.OnGiaTienChanging(value);
					this.SendPropertyChanging();
					this._GiaTien = value;
					this.SendPropertyChanged("GiaTien");
					this.OnGiaTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaNhap", DbType="Int")]
		public System.Nullable<int> GiaNhap
		{
			get
			{
				return this._GiaNhap;
			}
			set
			{
				if ((this._GiaNhap != value))
				{
					this.OnGiaNhapChanging(value);
					this.SendPropertyChanging();
					this._GiaNhap = value;
					this.SendPropertyChanged("GiaNhap");
					this.OnGiaNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NhaXuatBan", DbType="NVarChar(100)")]
		public string NhaXuatBan
		{
			get
			{
				return this._NhaXuatBan;
			}
			set
			{
				if ((this._NhaXuatBan != value))
				{
					this.OnNhaXuatBanChanging(value);
					this.SendPropertyChanging();
					this._NhaXuatBan = value;
					this.SendPropertyChanged("NhaXuatBan");
					this.OnNhaXuatBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamXuatBan", DbType="Int")]
		public System.Nullable<int> NamXuatBan
		{
			get
			{
				return this._NamXuatBan;
			}
			set
			{
				if ((this._NamXuatBan != value))
				{
					this.OnNamXuatBanChanging(value);
					this.SendPropertyChanging();
					this._NamXuatBan = value;
					this.SendPropertyChanged("NamXuatBan");
					this.OnNamXuatBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TacGia", DbType="NVarChar(100)")]
		public string TacGia
		{
			get
			{
				return this._TacGia;
			}
			set
			{
				if ((this._TacGia != value))
				{
					this.OnTacGiaChanging(value);
					this.SendPropertyChanging();
					this._TacGia = value;
					this.SendPropertyChanged("TacGia");
					this.OnTacGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="Bit")]
		public System.Nullable<bool> TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				if ((this._TrangThai != value))
				{
					this.OnTrangThaiChanging(value);
					this.SendPropertyChanging();
					this._TrangThai = value;
					this.SendPropertyChanged("TrangThai");
					this.OnTrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiamGia", DbType="Int")]
		public System.Nullable<int> GiamGia
		{
			get
			{
				return this._GiamGia;
			}
			set
			{
				if ((this._GiamGia != value))
				{
					this.OnGiamGiaChanging(value);
					this.SendPropertyChanging();
					this._GiamGia = value;
					this.SendPropertyChanged("GiamGia");
					this.OnGiamGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblSach_tblChiTietHoaDon", Storage="_tblChiTietHoaDons", ThisKey="MaSach", OtherKey="MaSach")]
		public EntitySet<tblChiTietHoaDon> tblChiTietHoaDons
		{
			get
			{
				return this._tblChiTietHoaDons;
			}
			set
			{
				this._tblChiTietHoaDons.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblChiTietHoaDons(tblChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.tblSach = this;
		}
		
		private void detach_tblChiTietHoaDons(tblChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.tblSach = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblTaiKhoan")]
	public partial class tblTaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhanVien;
		
		private string _MatKhau;
		
		private EntityRef<tblNhanVien> _tblNhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public tblTaiKhoan()
		{
			this._tblNhanVien = default(EntityRef<tblNhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					if (this._tblNhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblNhanVien_tblTaiKhoan", Storage="_tblNhanVien", ThisKey="MaNhanVien", OtherKey="MaNhanVien", IsForeignKey=true)]
		public tblNhanVien tblNhanVien
		{
			get
			{
				return this._tblNhanVien.Entity;
			}
			set
			{
				tblNhanVien previousValue = this._tblNhanVien.Entity;
				if (((previousValue != value) 
							|| (this._tblNhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblNhanVien.Entity = null;
						previousValue.tblTaiKhoan = null;
					}
					this._tblNhanVien.Entity = value;
					if ((value != null))
					{
						value.tblTaiKhoan = this;
						this._MaNhanVien = value.MaNhanVien;
					}
					else
					{
						this._MaNhanVien = default(string);
					}
					this.SendPropertyChanged("tblNhanVien");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblNhanVien")]
	public partial class tblNhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhanVien;
		
		private string _TenNhanVien;
		
		private string _CMND;
		
		private System.DateTime _NgaySinh;
		
		private string _GioiTinh;
		
		private string _SDT;
		
		private string _ChucVu;
		
		private System.Nullable<bool> _Trang_Thai;
		
		private EntitySet<tblHoaDon> _tblHoaDons;
		
		private EntityRef<tblTaiKhoan> _tblTaiKhoan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    partial void OnTenNhanVienChanging(string value);
    partial void OnTenNhanVienChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnNgaySinhChanging(System.DateTime value);
    partial void OnNgaySinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnChucVuChanging(string value);
    partial void OnChucVuChanged();
    partial void OnTrang_ThaiChanging(System.Nullable<bool> value);
    partial void OnTrang_ThaiChanged();
    #endregion
		
		public tblNhanVien()
		{
			this._tblHoaDons = new EntitySet<tblHoaDon>(new Action<tblHoaDon>(this.attach_tblHoaDons), new Action<tblHoaDon>(this.detach_tblHoaDons));
			this._tblTaiKhoan = default(EntityRef<tblTaiKhoan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhanVien", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNhanVien
		{
			get
			{
				return this._TenNhanVien;
			}
			set
			{
				if ((this._TenNhanVien != value))
				{
					this.OnTenNhanVienChanging(value);
					this.SendPropertyChanging();
					this._TenNhanVien = value;
					this.SendPropertyChanged("TenNhanVien");
					this.OnTenNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date NOT NULL")]
		public System.DateTime NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NChar(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucVu", DbType="NChar(10)")]
		public string ChucVu
		{
			get
			{
				return this._ChucVu;
			}
			set
			{
				if ((this._ChucVu != value))
				{
					this.OnChucVuChanging(value);
					this.SendPropertyChanging();
					this._ChucVu = value;
					this.SendPropertyChanged("ChucVu");
					this.OnChucVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Trang Thai]", Storage="_Trang_Thai", DbType="Bit")]
		public System.Nullable<bool> Trang_Thai
		{
			get
			{
				return this._Trang_Thai;
			}
			set
			{
				if ((this._Trang_Thai != value))
				{
					this.OnTrang_ThaiChanging(value);
					this.SendPropertyChanging();
					this._Trang_Thai = value;
					this.SendPropertyChanged("Trang_Thai");
					this.OnTrang_ThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblNhanVien_tblHoaDon", Storage="_tblHoaDons", ThisKey="MaNhanVien", OtherKey="MaNhanVien")]
		public EntitySet<tblHoaDon> tblHoaDons
		{
			get
			{
				return this._tblHoaDons;
			}
			set
			{
				this._tblHoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblNhanVien_tblTaiKhoan", Storage="_tblTaiKhoan", ThisKey="MaNhanVien", OtherKey="MaNhanVien", IsUnique=true, IsForeignKey=false)]
		public tblTaiKhoan tblTaiKhoan
		{
			get
			{
				return this._tblTaiKhoan.Entity;
			}
			set
			{
				tblTaiKhoan previousValue = this._tblTaiKhoan.Entity;
				if (((previousValue != value) 
							|| (this._tblTaiKhoan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblTaiKhoan.Entity = null;
						previousValue.tblNhanVien = null;
					}
					this._tblTaiKhoan.Entity = value;
					if ((value != null))
					{
						value.tblNhanVien = this;
					}
					this.SendPropertyChanged("tblTaiKhoan");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblHoaDons(tblHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.tblNhanVien = this;
		}
		
		private void detach_tblHoaDons(tblHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.tblNhanVien = null;
		}
	}
}
#pragma warning restore 1591
