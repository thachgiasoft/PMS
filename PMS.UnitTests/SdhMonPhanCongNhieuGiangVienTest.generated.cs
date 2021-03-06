﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SdhMonPhanCongNhieuGiangVienTest.cs instead.
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
    /// Provides tests for the and <see cref="SdhMonPhanCongNhieuGiangVien"/> objects (entity, collection and repository).
    /// </summary>
   public partial class SdhMonPhanCongNhieuGiangVienTest
    {
    	// the SdhMonPhanCongNhieuGiangVien instance used to test the repository.
		protected SdhMonPhanCongNhieuGiangVien mock;
		
		// the TList<SdhMonPhanCongNhieuGiangVien> instance used to test the repository.
		protected TList<SdhMonPhanCongNhieuGiangVien> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the SdhMonPhanCongNhieuGiangVien Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock SdhMonPhanCongNhieuGiangVien entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all SdhMonPhanCongNhieuGiangVien objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.SdhMonPhanCongNhieuGiangVienProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all SdhMonPhanCongNhieuGiangVien children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.SdhMonPhanCongNhieuGiangVienProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.SdhMonPhanCongNhieuGiangVienProvider.DeepLoading += new EntityProviderBaseCore<SdhMonPhanCongNhieuGiangVien, SdhMonPhanCongNhieuGiangVienKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.SdhMonPhanCongNhieuGiangVienProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("SdhMonPhanCongNhieuGiangVien instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.SdhMonPhanCongNhieuGiangVienProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock SdhMonPhanCongNhieuGiangVien entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhMonPhanCongNhieuGiangVien mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock SdhMonPhanCongNhieuGiangVien entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (SdhMonPhanCongNhieuGiangVien)CreateMockInstance(tm);
				DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock SdhMonPhanCongNhieuGiangVien entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhMonPhanCongNhieuGiangVien.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock SdhMonPhanCongNhieuGiangVien entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhMonPhanCongNhieuGiangVien.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<SdhMonPhanCongNhieuGiangVien>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a SdhMonPhanCongNhieuGiangVien collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhMonPhanCongNhieuGiangVienCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<SdhMonPhanCongNhieuGiangVien> mockCollection = new TList<SdhMonPhanCongNhieuGiangVien>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<SdhMonPhanCongNhieuGiangVien> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a SdhMonPhanCongNhieuGiangVien collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhMonPhanCongNhieuGiangVienCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<SdhMonPhanCongNhieuGiangVien>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<SdhMonPhanCongNhieuGiangVien> mockCollection = (TList<SdhMonPhanCongNhieuGiangVien>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<SdhMonPhanCongNhieuGiangVien> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhMonPhanCongNhieuGiangVien entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Insert(tm, entity);
				
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
				SdhMonPhanCongNhieuGiangVien entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				SdhMonPhanCongNhieuGiangVien t0 = DataRepository.SdhMonPhanCongNhieuGiangVienProvider.GetById(tm, entity.Id);
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
				
				SdhMonPhanCongNhieuGiangVien entity = mock.Copy() as SdhMonPhanCongNhieuGiangVien;
				entity = (SdhMonPhanCongNhieuGiangVien)mock.Clone();
				Assert.IsTrue(SdhMonPhanCongNhieuGiangVien.ValueEquals(entity, mock), "Clone is not working");
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
				SdhMonPhanCongNhieuGiangVien mock = CreateMockInstance(tm);
				bool result = DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				SdhMonPhanCongNhieuGiangVienQuery query = new SdhMonPhanCongNhieuGiangVienQuery();
			
				query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.Id, mock.Id.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.NhomMonHoc != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.NhomMonHoc, mock.NhomMonHoc.ToString());
				if(mock.MaHocPhan != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.MaHocPhan, mock.MaHocPhan.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.MaLop, mock.MaLop.ToString());
				if(mock.MaGiangVienQuanLy != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.MaGiangVienQuanLy, mock.MaGiangVienQuanLy.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.SiSo != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.SiSo, mock.SiSo.ToString());
				if(mock.LopClc != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.LopClc, mock.LopClc.ToString());
				if(mock.SoTietDayChuNhat != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.SoTietDayChuNhat, mock.SoTietDayChuNhat.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.Nhom, mock.Nhom.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(SdhMonPhanCongNhieuGiangVienColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				
				TList<SdhMonPhanCongNhieuGiangVien> results = DataRepository.SdhMonPhanCongNhieuGiangVienProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed SdhMonPhanCongNhieuGiangVien Entity with mock values.
		///</summary>
		static public SdhMonPhanCongNhieuGiangVien CreateMockInstance_Generated(TransactionManager tm)
		{		
			SdhMonPhanCongNhieuGiangVien mock = new SdhMonPhanCongNhieuGiangVien();
						
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.NhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SoTietDayChuNhat = TestUtility.Instance.RandomNumber();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			
		
			// create a temporary collection and add the item to it
			TList<SdhMonPhanCongNhieuGiangVien> tempMockCollection = new TList<SdhMonPhanCongNhieuGiangVien>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (SdhMonPhanCongNhieuGiangVien)mock;
		}
		
		
		///<summary>
		///  Update the Typed SdhMonPhanCongNhieuGiangVien Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, SdhMonPhanCongNhieuGiangVien mock)
		{
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.NhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SoTietDayChuNhat = TestUtility.Instance.RandomNumber();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			
		}
		#endregion
    }
}
