﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KcqUteKhoiLuongGiangDayTest.cs instead.
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
    /// Provides tests for the and <see cref="KcqUteKhoiLuongGiangDay"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KcqUteKhoiLuongGiangDayTest
    {
    	// the KcqUteKhoiLuongGiangDay instance used to test the repository.
		protected KcqUteKhoiLuongGiangDay mock;
		
		// the TList<KcqUteKhoiLuongGiangDay> instance used to test the repository.
		protected TList<KcqUteKhoiLuongGiangDay> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KcqUteKhoiLuongGiangDay Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KcqUteKhoiLuongGiangDay entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqUteKhoiLuongGiangDayProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KcqUteKhoiLuongGiangDayProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KcqUteKhoiLuongGiangDay objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KcqUteKhoiLuongGiangDayProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KcqUteKhoiLuongGiangDayProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KcqUteKhoiLuongGiangDayProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KcqUteKhoiLuongGiangDay children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KcqUteKhoiLuongGiangDayProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KcqUteKhoiLuongGiangDayProvider.DeepLoading += new EntityProviderBaseCore<KcqUteKhoiLuongGiangDay, KcqUteKhoiLuongGiangDayKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KcqUteKhoiLuongGiangDayProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KcqUteKhoiLuongGiangDay instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KcqUteKhoiLuongGiangDayProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KcqUteKhoiLuongGiangDay entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqUteKhoiLuongGiangDay mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqUteKhoiLuongGiangDayProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KcqUteKhoiLuongGiangDayProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KcqUteKhoiLuongGiangDayProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KcqUteKhoiLuongGiangDay entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KcqUteKhoiLuongGiangDay)CreateMockInstance(tm);
				DataRepository.KcqUteKhoiLuongGiangDayProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KcqUteKhoiLuongGiangDayProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KcqUteKhoiLuongGiangDayProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KcqUteKhoiLuongGiangDay entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqUteKhoiLuongGiangDay.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KcqUteKhoiLuongGiangDay entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqUteKhoiLuongGiangDay.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KcqUteKhoiLuongGiangDay>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KcqUteKhoiLuongGiangDay collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqUteKhoiLuongGiangDayCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KcqUteKhoiLuongGiangDay> mockCollection = new TList<KcqUteKhoiLuongGiangDay>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KcqUteKhoiLuongGiangDay> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KcqUteKhoiLuongGiangDay collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqUteKhoiLuongGiangDayCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KcqUteKhoiLuongGiangDay>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KcqUteKhoiLuongGiangDay> mockCollection = (TList<KcqUteKhoiLuongGiangDay>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KcqUteKhoiLuongGiangDay> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqUteKhoiLuongGiangDay entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqUteKhoiLuongGiangDayProvider.Insert(tm, entity);
				
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
				KcqUteKhoiLuongGiangDay entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqUteKhoiLuongGiangDayProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KcqUteKhoiLuongGiangDay t0 = DataRepository.KcqUteKhoiLuongGiangDayProvider.GetById(tm, entity.Id);
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
				
				KcqUteKhoiLuongGiangDay entity = mock.Copy() as KcqUteKhoiLuongGiangDay;
				entity = (KcqUteKhoiLuongGiangDay)mock.Clone();
				Assert.IsTrue(KcqUteKhoiLuongGiangDay.ValueEquals(entity, mock), "Clone is not working");
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
				KcqUteKhoiLuongGiangDay mock = CreateMockInstance(tm);
				bool result = DataRepository.KcqUteKhoiLuongGiangDayProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KcqUteKhoiLuongGiangDayQuery query = new KcqUteKhoiLuongGiangDayQuery();
			
				query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.Id, mock.Id.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.NhomMonHoc != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.NhomMonHoc, mock.NhomMonHoc.ToString());
				if(mock.MaHocPhan != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaHocPhan, mock.MaHocPhan.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaLop, mock.MaLop.ToString());
				if(mock.MaGiangVienQuanLy != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaGiangVienQuanLy, mock.MaGiangVienQuanLy.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.SiSo != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.SiSo, mock.SiSo.ToString());
				if(mock.LopClc != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.LopClc, mock.LopClc.ToString());
				if(mock.SoTietDayChuNhat != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.SoTietDayChuNhat, mock.SoTietDayChuNhat.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.Nhom, mock.Nhom.ToString());
				if(mock.MaLoaiHocPhanGanMoi != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaLoaiHocPhanGanMoi, mock.MaLoaiHocPhanGanMoi.ToString());
				if(mock.MaDiaDiem != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaDiaDiem, mock.MaDiaDiem.ToString());
				if(mock.MaDot != null)
					query.AppendEquals(KcqUteKhoiLuongGiangDayColumn.MaDot, mock.MaDot.ToString());
				
				TList<KcqUteKhoiLuongGiangDay> results = DataRepository.KcqUteKhoiLuongGiangDayProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KcqUteKhoiLuongGiangDay Entity with mock values.
		///</summary>
		static public KcqUteKhoiLuongGiangDay CreateMockInstance_Generated(TransactionManager tm)
		{		
			KcqUteKhoiLuongGiangDay mock = new KcqUteKhoiLuongGiangDay();
						
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
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLoaiHocPhanGanMoi = TestUtility.Instance.RandomString(9, false);;
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
			
		
			// create a temporary collection and add the item to it
			TList<KcqUteKhoiLuongGiangDay> tempMockCollection = new TList<KcqUteKhoiLuongGiangDay>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KcqUteKhoiLuongGiangDay)mock;
		}
		
		
		///<summary>
		///  Update the Typed KcqUteKhoiLuongGiangDay Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KcqUteKhoiLuongGiangDay mock)
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
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLoaiHocPhanGanMoi = TestUtility.Instance.RandomString(9, false);;
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
			
		}
		#endregion
    }
}
