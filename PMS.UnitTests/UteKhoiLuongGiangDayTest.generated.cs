﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file UteKhoiLuongGiangDayTest.cs instead.
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
    /// Provides tests for the and <see cref="UteKhoiLuongGiangDay"/> objects (entity, collection and repository).
    /// </summary>
   public partial class UteKhoiLuongGiangDayTest
    {
    	// the UteKhoiLuongGiangDay instance used to test the repository.
		protected UteKhoiLuongGiangDay mock;
		
		// the TList<UteKhoiLuongGiangDay> instance used to test the repository.
		protected TList<UteKhoiLuongGiangDay> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the UteKhoiLuongGiangDay Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock UteKhoiLuongGiangDay entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.UteKhoiLuongGiangDayProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.UteKhoiLuongGiangDayProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all UteKhoiLuongGiangDay objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.UteKhoiLuongGiangDayProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.UteKhoiLuongGiangDayProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.UteKhoiLuongGiangDayProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all UteKhoiLuongGiangDay children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.UteKhoiLuongGiangDayProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.UteKhoiLuongGiangDayProvider.DeepLoading += new EntityProviderBaseCore<UteKhoiLuongGiangDay, UteKhoiLuongGiangDayKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.UteKhoiLuongGiangDayProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("UteKhoiLuongGiangDay instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.UteKhoiLuongGiangDayProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock UteKhoiLuongGiangDay entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				UteKhoiLuongGiangDay mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.UteKhoiLuongGiangDayProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.UteKhoiLuongGiangDayProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.UteKhoiLuongGiangDayProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock UteKhoiLuongGiangDay entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (UteKhoiLuongGiangDay)CreateMockInstance(tm);
				DataRepository.UteKhoiLuongGiangDayProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.UteKhoiLuongGiangDayProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.UteKhoiLuongGiangDayProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock UteKhoiLuongGiangDay entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_UteKhoiLuongGiangDay.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock UteKhoiLuongGiangDay entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_UteKhoiLuongGiangDay.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<UteKhoiLuongGiangDay>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a UteKhoiLuongGiangDay collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_UteKhoiLuongGiangDayCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<UteKhoiLuongGiangDay> mockCollection = new TList<UteKhoiLuongGiangDay>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<UteKhoiLuongGiangDay> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a UteKhoiLuongGiangDay collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_UteKhoiLuongGiangDayCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<UteKhoiLuongGiangDay>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<UteKhoiLuongGiangDay> mockCollection = (TList<UteKhoiLuongGiangDay>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<UteKhoiLuongGiangDay> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				UteKhoiLuongGiangDay entity = CreateMockInstance(tm);
				bool result = DataRepository.UteKhoiLuongGiangDayProvider.Insert(tm, entity);
				
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
				UteKhoiLuongGiangDay entity = CreateMockInstance(tm);
				bool result = DataRepository.UteKhoiLuongGiangDayProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				UteKhoiLuongGiangDay t0 = DataRepository.UteKhoiLuongGiangDayProvider.GetById(tm, entity.Id);
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
				
				UteKhoiLuongGiangDay entity = mock.Copy() as UteKhoiLuongGiangDay;
				entity = (UteKhoiLuongGiangDay)mock.Clone();
				Assert.IsTrue(UteKhoiLuongGiangDay.ValueEquals(entity, mock), "Clone is not working");
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
				UteKhoiLuongGiangDay mock = CreateMockInstance(tm);
				bool result = DataRepository.UteKhoiLuongGiangDayProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				UteKhoiLuongGiangDayQuery query = new UteKhoiLuongGiangDayQuery();
			
				query.AppendEquals(UteKhoiLuongGiangDayColumn.Id, mock.Id.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.NhomMonHoc != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.NhomMonHoc, mock.NhomMonHoc.ToString());
				if(mock.MaHocPhan != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.MaHocPhan, mock.MaHocPhan.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.Nhom, mock.Nhom.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.MaLop, mock.MaLop.ToString());
				if(mock.MaGiangVienQuanLy != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.MaGiangVienQuanLy, mock.MaGiangVienQuanLy.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.SiSo != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.SiSo, mock.SiSo.ToString());
				if(mock.LopClc != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.LopClc, mock.LopClc.ToString());
				if(mock.SoTietDayChuNhat != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.SoTietDayChuNhat, mock.SoTietDayChuNhat.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.MaLoaiHocPhanGanMoi != null)
					query.AppendEquals(UteKhoiLuongGiangDayColumn.MaLoaiHocPhanGanMoi, mock.MaLoaiHocPhanGanMoi.ToString());
				
				TList<UteKhoiLuongGiangDay> results = DataRepository.UteKhoiLuongGiangDayProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed UteKhoiLuongGiangDay Entity with mock values.
		///</summary>
		static public UteKhoiLuongGiangDay CreateMockInstance_Generated(TransactionManager tm)
		{		
			UteKhoiLuongGiangDay mock = new UteKhoiLuongGiangDay();
						
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.NhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SoTietDayChuNhat = TestUtility.Instance.RandomNumber();
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.MaLoaiHocPhanGanMoi = TestUtility.Instance.RandomString(9, false);;
			
		
			// create a temporary collection and add the item to it
			TList<UteKhoiLuongGiangDay> tempMockCollection = new TList<UteKhoiLuongGiangDay>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (UteKhoiLuongGiangDay)mock;
		}
		
		
		///<summary>
		///  Update the Typed UteKhoiLuongGiangDay Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, UteKhoiLuongGiangDay mock)
		{
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.NhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SoTietDayChuNhat = TestUtility.Instance.RandomNumber();
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.MaLoaiHocPhanGanMoi = TestUtility.Instance.RandomString(9, false);;
			
		}
		#endregion
    }
}
