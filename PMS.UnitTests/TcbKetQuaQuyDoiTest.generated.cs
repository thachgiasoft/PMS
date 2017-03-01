﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file TcbKetQuaQuyDoiTest.cs instead.
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
    /// Provides tests for the and <see cref="TcbKetQuaQuyDoi"/> objects (entity, collection and repository).
    /// </summary>
   public partial class TcbKetQuaQuyDoiTest
    {
    	// the TcbKetQuaQuyDoi instance used to test the repository.
		protected TcbKetQuaQuyDoi mock;
		
		// the TList<TcbKetQuaQuyDoi> instance used to test the repository.
		protected TList<TcbKetQuaQuyDoi> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the TcbKetQuaQuyDoi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock TcbKetQuaQuyDoi entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TcbKetQuaQuyDoiProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.TcbKetQuaQuyDoiProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all TcbKetQuaQuyDoi objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.TcbKetQuaQuyDoiProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.TcbKetQuaQuyDoiProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.TcbKetQuaQuyDoiProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all TcbKetQuaQuyDoi children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.TcbKetQuaQuyDoiProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.TcbKetQuaQuyDoiProvider.DeepLoading += new EntityProviderBaseCore<TcbKetQuaQuyDoi, TcbKetQuaQuyDoiKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.TcbKetQuaQuyDoiProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("TcbKetQuaQuyDoi instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.TcbKetQuaQuyDoiProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock TcbKetQuaQuyDoi entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TcbKetQuaQuyDoi mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TcbKetQuaQuyDoiProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.TcbKetQuaQuyDoiProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.TcbKetQuaQuyDoiProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock TcbKetQuaQuyDoi entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (TcbKetQuaQuyDoi)CreateMockInstance(tm);
				DataRepository.TcbKetQuaQuyDoiProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.TcbKetQuaQuyDoiProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.TcbKetQuaQuyDoiProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock TcbKetQuaQuyDoi entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TcbKetQuaQuyDoi.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock TcbKetQuaQuyDoi entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TcbKetQuaQuyDoi.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<TcbKetQuaQuyDoi>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a TcbKetQuaQuyDoi collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TcbKetQuaQuyDoiCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<TcbKetQuaQuyDoi> mockCollection = new TList<TcbKetQuaQuyDoi>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<TcbKetQuaQuyDoi> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a TcbKetQuaQuyDoi collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TcbKetQuaQuyDoiCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<TcbKetQuaQuyDoi>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<TcbKetQuaQuyDoi> mockCollection = (TList<TcbKetQuaQuyDoi>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<TcbKetQuaQuyDoi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TcbKetQuaQuyDoi entity = CreateMockInstance(tm);
				bool result = DataRepository.TcbKetQuaQuyDoiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TcbKetQuaQuyDoi entity = CreateMockInstance(tm);
				bool result = DataRepository.TcbKetQuaQuyDoiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				TcbKetQuaQuyDoi t0 = DataRepository.TcbKetQuaQuyDoiProvider.GetById(tm, entity.Id);
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
				
				TcbKetQuaQuyDoi entity = mock.Copy() as TcbKetQuaQuyDoi;
				entity = (TcbKetQuaQuyDoi)mock.Clone();
				Assert.IsTrue(TcbKetQuaQuyDoi.ValueEquals(entity, mock), "Clone is not working");
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
				TcbKetQuaQuyDoi mock = CreateMockInstance(tm);
				bool result = DataRepository.TcbKetQuaQuyDoiProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				TcbKetQuaQuyDoiQuery query = new TcbKetQuaQuyDoiQuery();
			
				query.AppendEquals(TcbKetQuaQuyDoiColumn.Id, mock.Id.ToString());
				if(mock.MaKhoiLuongGiangDay != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaKhoiLuongGiangDay, mock.MaKhoiLuongGiangDay.ToString());
				if(mock.MaGiangVien != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.SoLuong != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.SoLuong, mock.SoLuong.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.LoaiHocPhan != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.LoaiHocPhan, mock.LoaiHocPhan.ToString());
				if(mock.MaBuoiHoc != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaBuoiHoc, mock.MaBuoiHoc.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaLop, mock.MaLop.ToString());
				if(mock.TietBatDau != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.TietBatDau, mock.TietBatDau.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.TinhTrang != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.TinhTrang, mock.TinhTrang.ToString());
				if(mock.NgayDay != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.NgayDay, mock.NgayDay.ToString());
				if(mock.MaBacDaoTao != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaBacDaoTao, mock.MaBacDaoTao.ToString());
				if(mock.MaKhoaHoc != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaKhoaHoc, mock.MaKhoaHoc.ToString());
				if(mock.MaKhoa != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaKhoa, mock.MaKhoa.ToString());
				if(mock.MaNhomMonHoc != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaNhomMonHoc, mock.MaNhomMonHoc.ToString());
				if(mock.MaCoSo != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.MaCoSo, mock.MaCoSo.ToString());
				if(mock.HeSoLopDong != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.HeSoLopDong, mock.HeSoLopDong.ToString());
				if(mock.DonGia != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.DonGia, mock.DonGia.ToString());
				if(mock.ThanhTien != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.ThanhTien, mock.ThanhTien.ToString());
				if(mock.CongTacPhi != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.CongTacPhi, mock.CongTacPhi.ToString());
				if(mock.TienGiangNgoaiGio != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.TienGiangNgoaiGio, mock.TienGiangNgoaiGio.ToString());
				if(mock.TongThanhTien != null)
					query.AppendEquals(TcbKetQuaQuyDoiColumn.TongThanhTien, mock.TongThanhTien.ToString());
				
				TList<TcbKetQuaQuyDoi> results = DataRepository.TcbKetQuaQuyDoiProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed TcbKetQuaQuyDoi Entity with mock values.
		///</summary>
		static public TcbKetQuaQuyDoi CreateMockInstance_Generated(TransactionManager tm)
		{		
			TcbKetQuaQuyDoi mock = new TcbKetQuaQuyDoi();
						
			mock.MaKhoiLuongGiangDay = TestUtility.Instance.RandomNumber();
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(99, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaBuoiHoc = TestUtility.Instance.RandomNumber();
			mock.MaLop = TestUtility.Instance.RandomString(249, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(9, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaCoSo = TestUtility.Instance.RandomString(24, false);;
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.CongTacPhi = (decimal)TestUtility.Instance.RandomShort();
			mock.TienGiangNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TongThanhTien = (decimal)TestUtility.Instance.RandomShort();
			
		
			// create a temporary collection and add the item to it
			TList<TcbKetQuaQuyDoi> tempMockCollection = new TList<TcbKetQuaQuyDoi>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (TcbKetQuaQuyDoi)mock;
		}
		
		
		///<summary>
		///  Update the Typed TcbKetQuaQuyDoi Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, TcbKetQuaQuyDoi mock)
		{
			mock.MaKhoiLuongGiangDay = TestUtility.Instance.RandomNumber();
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(99, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaBuoiHoc = TestUtility.Instance.RandomNumber();
			mock.MaLop = TestUtility.Instance.RandomString(249, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(9, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaCoSo = TestUtility.Instance.RandomString(24, false);;
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.CongTacPhi = (decimal)TestUtility.Instance.RandomShort();
			mock.TienGiangNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TongThanhTien = (decimal)TestUtility.Instance.RandomShort();
			
		}
		#endregion
    }
}