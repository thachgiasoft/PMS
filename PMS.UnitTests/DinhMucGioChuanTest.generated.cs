﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file DinhMucGioChuanTest.cs instead.
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
    /// Provides tests for the and <see cref="DinhMucGioChuan"/> objects (entity, collection and repository).
    /// </summary>
   public partial class DinhMucGioChuanTest
    {
    	// the DinhMucGioChuan instance used to test the repository.
		protected DinhMucGioChuan mock;
		
		// the TList<DinhMucGioChuan> instance used to test the repository.
		protected TList<DinhMucGioChuan> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the DinhMucGioChuan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock DinhMucGioChuan entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DinhMucGioChuanProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.DinhMucGioChuanProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all DinhMucGioChuan objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.DinhMucGioChuanProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.DinhMucGioChuanProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.DinhMucGioChuanProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all DinhMucGioChuan children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.DinhMucGioChuanProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.DinhMucGioChuanProvider.DeepLoading += new EntityProviderBaseCore<DinhMucGioChuan, DinhMucGioChuanKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.DinhMucGioChuanProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("DinhMucGioChuan instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.DinhMucGioChuanProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock DinhMucGioChuan entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DinhMucGioChuan mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DinhMucGioChuanProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.DinhMucGioChuanProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.DinhMucGioChuanProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock DinhMucGioChuan entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (DinhMucGioChuan)CreateMockInstance(tm);
				DataRepository.DinhMucGioChuanProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.DinhMucGioChuanProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.DinhMucGioChuanProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock DinhMucGioChuan entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DinhMucGioChuan.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock DinhMucGioChuan entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DinhMucGioChuan.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<DinhMucGioChuan>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a DinhMucGioChuan collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DinhMucGioChuanCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<DinhMucGioChuan> mockCollection = new TList<DinhMucGioChuan>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<DinhMucGioChuan> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a DinhMucGioChuan collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DinhMucGioChuanCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<DinhMucGioChuan>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<DinhMucGioChuan> mockCollection = (TList<DinhMucGioChuan>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<DinhMucGioChuan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DinhMucGioChuan entity = CreateMockInstance(tm);
				bool result = DataRepository.DinhMucGioChuanProvider.Insert(tm, entity);
				
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
				DinhMucGioChuan entity = CreateMockInstance(tm);
				bool result = DataRepository.DinhMucGioChuanProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				DinhMucGioChuan t0 = DataRepository.DinhMucGioChuanProvider.GetByMaDinhMuc(tm, entity.MaDinhMuc);
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
				
				DinhMucGioChuan entity = mock.Copy() as DinhMucGioChuan;
				entity = (DinhMucGioChuan)mock.Clone();
				Assert.IsTrue(DinhMucGioChuan.ValueEquals(entity, mock), "Clone is not working");
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
				DinhMucGioChuan mock = CreateMockInstance(tm);
				bool result = DataRepository.DinhMucGioChuanProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				DinhMucGioChuanQuery query = new DinhMucGioChuanQuery();
			
				query.AppendEquals(DinhMucGioChuanColumn.MaDinhMuc, mock.MaDinhMuc.ToString());
				if(mock.Stt != null)
					query.AppendEquals(DinhMucGioChuanColumn.Stt, mock.Stt.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(DinhMucGioChuanColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(DinhMucGioChuanColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.DinhMucMonHoc != null)
					query.AppendEquals(DinhMucGioChuanColumn.DinhMucMonHoc, mock.DinhMucMonHoc.ToString());
				if(mock.DinhMucMonGdtcQp != null)
					query.AppendEquals(DinhMucGioChuanColumn.DinhMucMonGdtcQp, mock.DinhMucMonGdtcQp.ToString());
				if(mock.DinhMucNckh != null)
					query.AppendEquals(DinhMucGioChuanColumn.DinhMucNckh, mock.DinhMucNckh.ToString());
				if(mock.HeSoLuongTangThem != null)
					query.AppendEquals(DinhMucGioChuanColumn.HeSoLuongTangThem, mock.HeSoLuongTangThem.ToString());
				if(mock.MaBacLuong != null)
					query.AppendEquals(DinhMucGioChuanColumn.MaBacLuong, mock.MaBacLuong.ToString());
				if(mock.DinhMucHoatDongChuyenMonKhac != null)
					query.AppendEquals(DinhMucGioChuanColumn.DinhMucHoatDongChuyenMonKhac, mock.DinhMucHoatDongChuyenMonKhac.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(DinhMucGioChuanColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(DinhMucGioChuanColumn.HocKy, mock.HocKy.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(DinhMucGioChuanColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(DinhMucGioChuanColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				if(mock.TongDinhMuc != null)
					query.AppendEquals(DinhMucGioChuanColumn.TongDinhMuc, mock.TongDinhMuc.ToString());
				if(mock.HeSo != null)
					query.AppendEquals(DinhMucGioChuanColumn.HeSo, mock.HeSo.ToString());
				if(mock.PhanLoaiGiangVien != null)
					query.AppendEquals(DinhMucGioChuanColumn.PhanLoaiGiangVien, mock.PhanLoaiGiangVien.ToString());
				if(mock.TuHeSoLuong != null)
					query.AppendEquals(DinhMucGioChuanColumn.TuHeSoLuong, mock.TuHeSoLuong.ToString());
				if(mock.DenHeSoLuong != null)
					query.AppendEquals(DinhMucGioChuanColumn.DenHeSoLuong, mock.DenHeSoLuong.ToString());
				
				TList<DinhMucGioChuan> results = DataRepository.DinhMucGioChuanProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed DinhMucGioChuan Entity with mock values.
		///</summary>
		static public DinhMucGioChuan CreateMockInstance_Generated(TransactionManager tm)
		{		
			DinhMucGioChuan mock = new DinhMucGioChuan();
						
			mock.Stt = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.DinhMucMonHoc = TestUtility.Instance.RandomNumber();
			mock.DinhMucMonGdtcQp = TestUtility.Instance.RandomNumber();
			mock.DinhMucNckh = TestUtility.Instance.RandomNumber();
			mock.HeSoLuongTangThem = (decimal)TestUtility.Instance.RandomShort();
			mock.MaBacLuong = TestUtility.Instance.RandomString(9, false);;
			mock.DinhMucHoatDongChuyenMonKhac = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(9, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.TongDinhMuc = TestUtility.Instance.RandomNumber();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.PhanLoaiGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.TuHeSoLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.DenHeSoLuong = (decimal)TestUtility.Instance.RandomShort();
			
		
			// create a temporary collection and add the item to it
			TList<DinhMucGioChuan> tempMockCollection = new TList<DinhMucGioChuan>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (DinhMucGioChuan)mock;
		}
		
		
		///<summary>
		///  Update the Typed DinhMucGioChuan Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, DinhMucGioChuan mock)
		{
			mock.Stt = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.DinhMucMonHoc = TestUtility.Instance.RandomNumber();
			mock.DinhMucMonGdtcQp = TestUtility.Instance.RandomNumber();
			mock.DinhMucNckh = TestUtility.Instance.RandomNumber();
			mock.HeSoLuongTangThem = (decimal)TestUtility.Instance.RandomShort();
			mock.MaBacLuong = TestUtility.Instance.RandomString(9, false);;
			mock.DinhMucHoatDongChuyenMonKhac = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(9, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.TongDinhMuc = TestUtility.Instance.RandomNumber();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.PhanLoaiGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.TuHeSoLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.DenHeSoLuong = (decimal)TestUtility.Instance.RandomShort();
			
		}
		#endregion
    }
}
