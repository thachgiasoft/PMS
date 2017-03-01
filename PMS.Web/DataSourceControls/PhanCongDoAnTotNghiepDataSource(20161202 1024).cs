#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.PhanCongDoAnTotNghiepProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(PhanCongDoAnTotNghiepDataSourceDesigner))]
	public class PhanCongDoAnTotNghiepDataSource : ProviderDataSource<PhanCongDoAnTotNghiep, PhanCongDoAnTotNghiepKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepDataSource class.
		/// </summary>
		public PhanCongDoAnTotNghiepDataSource() : base(new PhanCongDoAnTotNghiepService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the PhanCongDoAnTotNghiepDataSourceView used by the PhanCongDoAnTotNghiepDataSource.
		/// </summary>
		protected PhanCongDoAnTotNghiepDataSourceView PhanCongDoAnTotNghiepView
		{
			get { return ( View as PhanCongDoAnTotNghiepDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the PhanCongDoAnTotNghiepDataSource control invokes to retrieve data.
		/// </summary>
		public PhanCongDoAnTotNghiepSelectMethod SelectMethod
		{
			get
			{
				PhanCongDoAnTotNghiepSelectMethod selectMethod = PhanCongDoAnTotNghiepSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (PhanCongDoAnTotNghiepSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the PhanCongDoAnTotNghiepDataSourceView class that is to be
		/// used by the PhanCongDoAnTotNghiepDataSource.
		/// </summary>
		/// <returns>An instance of the PhanCongDoAnTotNghiepDataSourceView class.</returns>
		protected override BaseDataSourceView<PhanCongDoAnTotNghiep, PhanCongDoAnTotNghiepKey> GetNewDataSourceView()
		{
			return new PhanCongDoAnTotNghiepDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the PhanCongDoAnTotNghiepDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class PhanCongDoAnTotNghiepDataSourceView : ProviderDataSourceView<PhanCongDoAnTotNghiep, PhanCongDoAnTotNghiepKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the PhanCongDoAnTotNghiepDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public PhanCongDoAnTotNghiepDataSourceView(PhanCongDoAnTotNghiepDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal PhanCongDoAnTotNghiepDataSource PhanCongDoAnTotNghiepOwner
		{
			get { return Owner as PhanCongDoAnTotNghiepDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal PhanCongDoAnTotNghiepSelectMethod SelectMethod
		{
			get { return PhanCongDoAnTotNghiepOwner.SelectMethod; }
			set { PhanCongDoAnTotNghiepOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal PhanCongDoAnTotNghiepService PhanCongDoAnTotNghiepProvider
		{
			get { return Provider as PhanCongDoAnTotNghiepService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<PhanCongDoAnTotNghiep> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<PhanCongDoAnTotNghiep> results = null;
			PhanCongDoAnTotNghiep item;
			count = 0;
			
			System.String _maLopHocPhan;
			System.String _maSinhVien;
			System.String sp2784_MaLopHocPhan;

			switch ( SelectMethod )
			{
				case PhanCongDoAnTotNghiepSelectMethod.Get:
					PhanCongDoAnTotNghiepKey entityKey  = new PhanCongDoAnTotNghiepKey();
					entityKey.Load(values);
					item = PhanCongDoAnTotNghiepProvider.Get(entityKey);
					results = new TList<PhanCongDoAnTotNghiep>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case PhanCongDoAnTotNghiepSelectMethod.GetAll:
                    results = PhanCongDoAnTotNghiepProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case PhanCongDoAnTotNghiepSelectMethod.GetPaged:
					results = PhanCongDoAnTotNghiepProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case PhanCongDoAnTotNghiepSelectMethod.Find:
					if ( FilterParameters != null )
						results = PhanCongDoAnTotNghiepProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = PhanCongDoAnTotNghiepProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case PhanCongDoAnTotNghiepSelectMethod.GetByMaLopHocPhanMaSinhVien:
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					_maSinhVien = ( values["MaSinhVien"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaSinhVien"], typeof(System.String)) : string.Empty;
					item = PhanCongDoAnTotNghiepProvider.GetByMaLopHocPhanMaSinhVien(_maLopHocPhan, _maSinhVien);
					results = new TList<PhanCongDoAnTotNghiep>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case PhanCongDoAnTotNghiepSelectMethod.GetByMaLopHocPhan:
					sp2784_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					results = PhanCongDoAnTotNghiepProvider.GetByMaLopHocPhan(sp2784_MaLopHocPhan, StartIndex, PageSize);
					break;
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == PhanCongDoAnTotNghiepSelectMethod.Get || SelectMethod == PhanCongDoAnTotNghiepSelectMethod.GetByMaLopHocPhanMaSinhVien )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				PhanCongDoAnTotNghiep entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					PhanCongDoAnTotNghiepProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<PhanCongDoAnTotNghiep> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			PhanCongDoAnTotNghiepProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region PhanCongDoAnTotNghiepDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the PhanCongDoAnTotNghiepDataSource class.
	/// </summary>
	public class PhanCongDoAnTotNghiepDataSourceDesigner : ProviderDataSourceDesigner<PhanCongDoAnTotNghiep, PhanCongDoAnTotNghiepKey>
	{
		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepDataSourceDesigner class.
		/// </summary>
		public PhanCongDoAnTotNghiepDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhanCongDoAnTotNghiepSelectMethod SelectMethod
		{
			get { return ((PhanCongDoAnTotNghiepDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new PhanCongDoAnTotNghiepDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region PhanCongDoAnTotNghiepDataSourceActionList

	/// <summary>
	/// Supports the PhanCongDoAnTotNghiepDataSourceDesigner class.
	/// </summary>
	internal class PhanCongDoAnTotNghiepDataSourceActionList : DesignerActionList
	{
		private PhanCongDoAnTotNghiepDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public PhanCongDoAnTotNghiepDataSourceActionList(PhanCongDoAnTotNghiepDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhanCongDoAnTotNghiepSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion PhanCongDoAnTotNghiepDataSourceActionList
	
	#endregion PhanCongDoAnTotNghiepDataSourceDesigner
	
	#region PhanCongDoAnTotNghiepSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the PhanCongDoAnTotNghiepDataSource.SelectMethod property.
	/// </summary>
	public enum PhanCongDoAnTotNghiepSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaLopHocPhanMaSinhVien method.
		/// </summary>
		GetByMaLopHocPhanMaSinhVien,
		/// <summary>
		/// Represents the GetByMaLopHocPhan method.
		/// </summary>
		GetByMaLopHocPhan
	}
	
	#endregion PhanCongDoAnTotNghiepSelectMethod

	#region PhanCongDoAnTotNghiepFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanCongDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanCongDoAnTotNghiepFilter : SqlFilter<PhanCongDoAnTotNghiepColumn>
	{
	}
	
	#endregion PhanCongDoAnTotNghiepFilter

	#region PhanCongDoAnTotNghiepExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanCongDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanCongDoAnTotNghiepExpressionBuilder : SqlExpressionBuilder<PhanCongDoAnTotNghiepColumn>
	{
	}
	
	#endregion PhanCongDoAnTotNghiepExpressionBuilder	

	#region PhanCongDoAnTotNghiepProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;PhanCongDoAnTotNghiepChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="PhanCongDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanCongDoAnTotNghiepProperty : ChildEntityProperty<PhanCongDoAnTotNghiepChildEntityTypes>
	{
	}
	
	#endregion PhanCongDoAnTotNghiepProperty
}

