﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ThuMoiGiangHopDongThinhGiangTest.cs instead.
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
    /// Provides tests for the and <see cref="ThuMoiGiangHopDongThinhGiang"/> objects (entity, collection and repository).
    /// </summary>
   public partial class ThuMoiGiangHopDongThinhGiangTest
    {
    	// the ThuMoiGiangHopDongThinhGiang instance used to test the repository.
		protected ThuMoiGiangHopDongThinhGiang mock;
		
		// the TList<ThuMoiGiangHopDongThinhGiang> instance used to test the repository.
		protected TList<ThuMoiGiangHopDongThinhGiang> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the ThuMoiGiangHopDongThinhGiang Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock ThuMoiGiangHopDongThinhGiang entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all ThuMoiGiangHopDongThinhGiang objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.ThuMoiGiangHopDongThinhGiangProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all ThuMoiGiangHopDongThinhGiang children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.ThuMoiGiangHopDongThinhGiangProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.ThuMoiGiangHopDongThinhGiangProvider.DeepLoading += new EntityProviderBaseCore<ThuMoiGiangHopDongThinhGiang, ThuMoiGiangHopDongThinhGiangKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.ThuMoiGiangHopDongThinhGiangProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("ThuMoiGiangHopDongThinhGiang instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.ThuMoiGiangHopDongThinhGiangProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock ThuMoiGiangHopDongThinhGiang entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ThuMoiGiangHopDongThinhGiang mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock ThuMoiGiangHopDongThinhGiang entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (ThuMoiGiangHopDongThinhGiang)CreateMockInstance(tm);
				DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ThuMoiGiangHopDongThinhGiang entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThuMoiGiangHopDongThinhGiang.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock ThuMoiGiangHopDongThinhGiang entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThuMoiGiangHopDongThinhGiang.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<ThuMoiGiangHopDongThinhGiang>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ThuMoiGiangHopDongThinhGiang collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThuMoiGiangHopDongThinhGiangCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<ThuMoiGiangHopDongThinhGiang> mockCollection = new TList<ThuMoiGiangHopDongThinhGiang>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<ThuMoiGiangHopDongThinhGiang> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a ThuMoiGiangHopDongThinhGiang collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThuMoiGiangHopDongThinhGiangCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<ThuMoiGiangHopDongThinhGiang>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<ThuMoiGiangHopDongThinhGiang> mockCollection = (TList<ThuMoiGiangHopDongThinhGiang>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<ThuMoiGiangHopDongThinhGiang> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ThuMoiGiangHopDongThinhGiang entity = CreateMockInstance(tm);
				bool result = DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Insert(tm, entity);
				
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
				ThuMoiGiangHopDongThinhGiang entity = CreateMockInstance(tm);
				bool result = DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				ThuMoiGiangHopDongThinhGiang t0 = DataRepository.ThuMoiGiangHopDongThinhGiangProvider.GetByMaGiangVienMaLopHocPhanMaLopSinhVien(tm, entity.MaGiangVien, entity.MaLopHocPhan, entity.MaLopSinhVien);
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
				
				ThuMoiGiangHopDongThinhGiang entity = mock.Copy() as ThuMoiGiangHopDongThinhGiang;
				entity = (ThuMoiGiangHopDongThinhGiang)mock.Clone();
				Assert.IsTrue(ThuMoiGiangHopDongThinhGiang.ValueEquals(entity, mock), "Clone is not working");
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
				ThuMoiGiangHopDongThinhGiang mock = CreateMockInstance(tm);
				bool result = DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				ThuMoiGiangHopDongThinhGiangQuery query = new ThuMoiGiangHopDongThinhGiangQuery();
			
				query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.MaGiangVien, mock.MaGiangVien.ToString());
				query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.MaBacDaoTao, mock.MaBacDaoTao.ToString());
				query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.MaLoaiHinh, mock.MaLoaiHinh.ToString());
				query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.SiSoLop != null)
					query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.SiSoLop, mock.SiSoLop.ToString());
				if(mock.HeSoLd != null)
					query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.HeSoLd, mock.HeSoLd.ToString());
				if(mock.HeSoTinChi != null)
					query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.HeSoTinChi, mock.HeSoTinChi.ToString());
				if(mock.TietQuyDoi != null)
					query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.TietQuyDoi, mock.TietQuyDoi.ToString());
				if(mock.NgayBatDauDay != null)
					query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.NgayBatDauDay, mock.NgayBatDauDay.ToString());
				if(mock.NgayKetThucDay != null)
					query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.NgayKetThucDay, mock.NgayKetThucDay.ToString());
				query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.MaLopSinhVien, mock.MaLopSinhVien.ToString());
				if(mock.HoanTat != null)
					query.AppendEquals(ThuMoiGiangHopDongThinhGiangColumn.HoanTat, mock.HoanTat.ToString());
				
				TList<ThuMoiGiangHopDongThinhGiang> results = DataRepository.ThuMoiGiangHopDongThinhGiangProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed ThuMoiGiangHopDongThinhGiang Entity with mock values.
		///</summary>
		static public ThuMoiGiangHopDongThinhGiang CreateMockInstance_Generated(TransactionManager tm)
		{		
			ThuMoiGiangHopDongThinhGiang mock = new ThuMoiGiangHopDongThinhGiang();
						
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(14, false);;
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiHinh = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			mock.HeSoLd = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayBatDauDay = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThucDay = TestUtility.Instance.RandomDateTime();
			mock.MaLopSinhVien = TestUtility.Instance.RandomString(9, false);;
			mock.HoanTat = TestUtility.Instance.RandomBoolean();
			
		
			// create a temporary collection and add the item to it
			TList<ThuMoiGiangHopDongThinhGiang> tempMockCollection = new TList<ThuMoiGiangHopDongThinhGiang>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (ThuMoiGiangHopDongThinhGiang)mock;
		}
		
		
		///<summary>
		///  Update the Typed ThuMoiGiangHopDongThinhGiang Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, ThuMoiGiangHopDongThinhGiang mock)
		{
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiHinh = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			mock.HeSoLd = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayBatDauDay = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThucDay = TestUtility.Instance.RandomDateTime();
			mock.HoanTat = TestUtility.Instance.RandomBoolean();
			
		}
		#endregion
    }
}
