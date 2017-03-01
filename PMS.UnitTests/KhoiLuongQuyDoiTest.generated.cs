﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KhoiLuongQuyDoiTest.cs instead.
*/

#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;

#endregion

namespace PMS.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="KhoiLuongQuyDoi"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KhoiLuongQuyDoiTest
    {
    	// the KhoiLuongQuyDoi instance used to test the repository.
		protected KhoiLuongQuyDoi mock;
		
		// the TList<KhoiLuongQuyDoi> instance used to test the repository.
		protected TList<KhoiLuongQuyDoi> mockCollection;
		
		protected static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
			}			
			return transactionManager;
		}
		       
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {		
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the KhoiLuongQuyDoi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {   		
			System.Console.WriteLine("All Tests Completed");
			System.Console.WriteLine();
        }
    
    
		/// <summary>
		/// Inserts a mock KhoiLuongQuyDoi entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongQuyDoiProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KhoiLuongQuyDoiProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KhoiLuongQuyDoi objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KhoiLuongQuyDoiProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KhoiLuongQuyDoiProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KhoiLuongQuyDoiProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KhoiLuongQuyDoi children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KhoiLuongQuyDoiProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KhoiLuongQuyDoiProvider.DeepLoading += new EntityProviderBaseCore<KhoiLuongQuyDoi, KhoiLuongQuyDoiKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KhoiLuongQuyDoiProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KhoiLuongQuyDoi instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KhoiLuongQuyDoiProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KhoiLuongQuyDoi entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongQuyDoi mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongQuyDoiProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KhoiLuongQuyDoiProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KhoiLuongQuyDoiProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KhoiLuongQuyDoi entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KhoiLuongQuyDoi)CreateMockInstance(tm);
				DataRepository.KhoiLuongQuyDoiProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KhoiLuongQuyDoiProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KhoiLuongQuyDoiProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KhoiLuongQuyDoi entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongQuyDoi.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KhoiLuongQuyDoi entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongQuyDoi.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KhoiLuongQuyDoi>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KhoiLuongQuyDoi collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongQuyDoiCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KhoiLuongQuyDoi> mockCollection = new TList<KhoiLuongQuyDoi>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KhoiLuongQuyDoi> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KhoiLuongQuyDoi collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongQuyDoiCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KhoiLuongQuyDoi>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KhoiLuongQuyDoi> mockCollection = (TList<KhoiLuongQuyDoi>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KhoiLuongQuyDoi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongQuyDoi entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongQuyDoiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<KhoiLuongQuyDoi> t0 = DataRepository.KhoiLuongQuyDoiProvider.GetByMaKhoiLuongGiangDay(tm, entity.MaKhoiLuongGiangDay, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongQuyDoi entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongQuyDoiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KhoiLuongQuyDoi t0 = DataRepository.KhoiLuongQuyDoiProvider.GetByMaKhoiLuongQuyDoi(tm, entity.MaKhoiLuongQuyDoi);
			}
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				
				KhoiLuongQuyDoi entity = mock.Copy() as KhoiLuongQuyDoi;
				entity = (KhoiLuongQuyDoi)mock.Clone();
				Assert.IsTrue(KhoiLuongQuyDoi.ValueEquals(entity, mock), "Clone is not working");
			}
		}
		
		/// <summary>
		/// Test Find using the Query class
		/// </summary>
		private void Step_30_TestFindByQuery_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Insert Mock Instance
				KhoiLuongQuyDoi mock = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongQuyDoiProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KhoiLuongQuyDoiQuery query = new KhoiLuongQuyDoiQuery();
			
				query.AppendEquals(KhoiLuongQuyDoiColumn.MaKhoiLuongQuyDoi, mock.MaKhoiLuongQuyDoi.ToString());
				if(mock.MaKhoiLuongGiangDay != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaKhoiLuongGiangDay, mock.MaKhoiLuongGiangDay.ToString());
				if(mock.MaGiangVien != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.SoLuong != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.SoLuong, mock.SoLuong.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.LoaiHocPhan != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.LoaiHocPhan, mock.LoaiHocPhan.ToString());
				if(mock.MaBuoiHoc != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaBuoiHoc, mock.MaBuoiHoc.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaLop, mock.MaLop.ToString());
				if(mock.TietBatDau != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.TietBatDau, mock.TietBatDau.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.TinhTrang != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.TinhTrang, mock.TinhTrang.ToString());
				if(mock.NgayDay != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.NgayDay, mock.NgayDay.ToString());
				if(mock.MaBacDaoTao != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaBacDaoTao, mock.MaBacDaoTao.ToString());
				if(mock.MaKhoaHoc != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaKhoaHoc, mock.MaKhoaHoc.ToString());
				if(mock.MaKhoa != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaKhoa, mock.MaKhoa.ToString());
				if(mock.MaNhomMonHoc != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaNhomMonHoc, mock.MaNhomMonHoc.ToString());
				if(mock.MaPhongHoc != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MaPhongHoc, mock.MaPhongHoc.ToString());
				if(mock.HeSoCongViec != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoCongViec, mock.HeSoCongViec.ToString());
				if(mock.HeSoBacDaoTao != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoBacDaoTao, mock.HeSoBacDaoTao.ToString());
				if(mock.HeSoNgonNgu != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoNgonNgu, mock.HeSoNgonNgu.ToString());
				if(mock.HeSoChucDanhChuyenMon != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoChucDanhChuyenMon, mock.HeSoChucDanhChuyenMon.ToString());
				if(mock.HeSoLopDong != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoLopDong, mock.HeSoLopDong.ToString());
				if(mock.HeSoCoSo != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoCoSo, mock.HeSoCoSo.ToString());
				if(mock.SoTietThucTeQuyDoi != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.SoTietThucTeQuyDoi, mock.SoTietThucTeQuyDoi.ToString());
				if(mock.TietQuyDoi != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.TietQuyDoi, mock.TietQuyDoi.ToString());
				if(mock.HeSoQuyDoiThucHanhSangLyThuyet != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoQuyDoiThucHanhSangLyThuyet, mock.HeSoQuyDoiThucHanhSangLyThuyet.ToString());
				if(mock.HeSoNgoaiGio != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoNgoaiGio, mock.HeSoNgoaiGio.ToString());
				if(mock.LoaiLop != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.LoaiLop, mock.LoaiLop.ToString());
				if(mock.HeSoClcCntn != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoClcCntn, mock.HeSoClcCntn.ToString());
				if(mock.HeSoThinhGiangMonChuyenNganh != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoThinhGiangMonChuyenNganh, mock.HeSoThinhGiangMonChuyenNganh.ToString());
				if(mock.NgonNguGiangDay != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.NgonNguGiangDay, mock.NgonNguGiangDay.ToString());
				if(mock.HeSoTroCapGiangDay != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoTroCapGiangDay, mock.HeSoTroCapGiangDay.ToString());
				if(mock.HeSoTroCap != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoTroCap, mock.HeSoTroCap.ToString());
				if(mock.HeSoLuong != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoLuong, mock.HeSoLuong.ToString());
				if(mock.HeSoMonMoi != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoMonMoi, mock.HeSoMonMoi.ToString());
				if(mock.HeSoNienCheTinChi != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoNienCheTinChi, mock.HeSoNienCheTinChi.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.MucThanhToan != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.MucThanhToan, mock.MucThanhToan.ToString());
				if(mock.HeSoKhoiNganh != null)
					query.AppendEquals(KhoiLuongQuyDoiColumn.HeSoKhoiNganh, mock.HeSoKhoiNganh.ToString());
				
				TList<KhoiLuongQuyDoi> results = DataRepository.KhoiLuongQuyDoiProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KhoiLuongQuyDoi Entity with mock values.
		///</summary>
		static public KhoiLuongQuyDoi CreateMockInstance_Generated(TransactionManager tm)
		{		
			KhoiLuongQuyDoi mock = new KhoiLuongQuyDoi();
						
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(99, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.MaBuoiHoc = TestUtility.Instance.RandomNumber();
			mock.MaLop = TestUtility.Instance.RandomString(126, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(99, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaPhongHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoCongViec = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoBacDaoTao = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgonNgu = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoChucDanhChuyenMon = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoCoSo = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTietThucTeQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoQuyDoiThucHanhSangLyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.LoaiLop = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoClcCntn = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoThinhGiangMonChuyenNganh = (decimal)TestUtility.Instance.RandomShort();
			mock.NgonNguGiangDay = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoTroCapGiangDay = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoTroCap = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoMonMoi = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNienCheTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.MucThanhToan = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoKhoiNganh = (decimal)TestUtility.Instance.RandomShort();
			
			//OneToOneRelationship
			KhoiLuongGiangDayChiTiet mockKhoiLuongGiangDayChiTietByMaKhoiLuongGiangDay = KhoiLuongGiangDayChiTietTest.CreateMockInstance(tm);
			DataRepository.KhoiLuongGiangDayChiTietProvider.Insert(tm, mockKhoiLuongGiangDayChiTietByMaKhoiLuongGiangDay);
			mock.MaKhoiLuongGiangDay = mockKhoiLuongGiangDayChiTietByMaKhoiLuongGiangDay.MaKhoiLuong;
		
			// create a temporary collection and add the item to it
			TList<KhoiLuongQuyDoi> tempMockCollection = new TList<KhoiLuongQuyDoi>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KhoiLuongQuyDoi)mock;
		}
		
		
		///<summary>
		///  Update the Typed KhoiLuongQuyDoi Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KhoiLuongQuyDoi mock)
		{
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(99, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.MaBuoiHoc = TestUtility.Instance.RandomNumber();
			mock.MaLop = TestUtility.Instance.RandomString(126, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(99, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaPhongHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoCongViec = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoBacDaoTao = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgonNgu = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoChucDanhChuyenMon = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoCoSo = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTietThucTeQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoQuyDoiThucHanhSangLyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.LoaiLop = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoClcCntn = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoThinhGiangMonChuyenNganh = (decimal)TestUtility.Instance.RandomShort();
			mock.NgonNguGiangDay = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoTroCapGiangDay = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoTroCap = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoMonMoi = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNienCheTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.MucThanhToan = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoKhoiNganh = (decimal)TestUtility.Instance.RandomShort();
			
			//OneToOneRelationship
			KhoiLuongGiangDayChiTiet mockKhoiLuongGiangDayChiTietByMaKhoiLuongGiangDay = KhoiLuongGiangDayChiTietTest.CreateMockInstance(tm);
			DataRepository.KhoiLuongGiangDayChiTietProvider.Insert(tm, mockKhoiLuongGiangDayChiTietByMaKhoiLuongGiangDay);
			mock.MaKhoiLuongGiangDay = mockKhoiLuongGiangDayChiTietByMaKhoiLuongGiangDay.MaKhoiLuong;
					
		}
		#endregion
    }
}
