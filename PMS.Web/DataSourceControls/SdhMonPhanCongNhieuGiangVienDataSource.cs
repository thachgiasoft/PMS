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
	/// Represents the DataRepository.SdhMonPhanCongNhieuGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhMonPhanCongNhieuGiangVienDataSourceDesigner))]
	public class SdhMonPhanCongNhieuGiangVienDataSource : ProviderDataSource<SdhMonPhanCongNhieuGiangVien, SdhMonPhanCongNhieuGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienDataSource class.
		/// </summary>
		public SdhMonPhanCongNhieuGiangVienDataSource() : base(new SdhMonPhanCongNhieuGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhMonPhanCongNhieuGiangVienDataSourceView used by the SdhMonPhanCongNhieuGiangVienDataSource.
		/// </summary>
		protected SdhMonPhanCongNhieuGiangVienDataSourceView SdhMonPhanCongNhieuGiangVienView
		{
			get { return ( View as SdhMonPhanCongNhieuGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhMonPhanCongNhieuGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public SdhMonPhanCongNhieuGiangVienSelectMethod SelectMethod
		{
			get
			{
				SdhMonPhanCongNhieuGiangVienSelectMethod selectMethod = SdhMonPhanCongNhieuGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhMonPhanCongNhieuGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhMonPhanCongNhieuGiangVienDataSourceView class that is to be
		/// used by the SdhMonPhanCongNhieuGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the SdhMonPhanCongNhieuGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhMonPhanCongNhieuGiangVien, SdhMonPhanCongNhieuGiangVienKey> GetNewDataSourceView()
		{
			return new SdhMonPhanCongNhieuGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhMonPhanCongNhieuGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhMonPhanCongNhieuGiangVienDataSourceView : ProviderDataSourceView<SdhMonPhanCongNhieuGiangVien, SdhMonPhanCongNhieuGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhMonPhanCongNhieuGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhMonPhanCongNhieuGiangVienDataSourceView(SdhMonPhanCongNhieuGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhMonPhanCongNhieuGiangVienDataSource SdhMonPhanCongNhieuGiangVienOwner
		{
			get { return Owner as SdhMonPhanCongNhieuGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhMonPhanCongNhieuGiangVienSelectMethod SelectMethod
		{
			get { return SdhMonPhanCongNhieuGiangVienOwner.SelectMethod; }
			set { SdhMonPhanCongNhieuGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhMonPhanCongNhieuGiangVienService SdhMonPhanCongNhieuGiangVienProvider
		{
			get { return Provider as SdhMonPhanCongNhieuGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhMonPhanCongNhieuGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhMonPhanCongNhieuGiangVien> results = null;
			SdhMonPhanCongNhieuGiangVien item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case SdhMonPhanCongNhieuGiangVienSelectMethod.Get:
					SdhMonPhanCongNhieuGiangVienKey entityKey  = new SdhMonPhanCongNhieuGiangVienKey();
					entityKey.Load(values);
					item = SdhMonPhanCongNhieuGiangVienProvider.Get(entityKey);
					results = new TList<SdhMonPhanCongNhieuGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhMonPhanCongNhieuGiangVienSelectMethod.GetAll:
                    results = SdhMonPhanCongNhieuGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhMonPhanCongNhieuGiangVienSelectMethod.GetPaged:
					results = SdhMonPhanCongNhieuGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhMonPhanCongNhieuGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhMonPhanCongNhieuGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhMonPhanCongNhieuGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhMonPhanCongNhieuGiangVienSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = SdhMonPhanCongNhieuGiangVienProvider.GetById(_id);
					results = new TList<SdhMonPhanCongNhieuGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
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
			if ( SelectMethod == SdhMonPhanCongNhieuGiangVienSelectMethod.Get || SelectMethod == SdhMonPhanCongNhieuGiangVienSelectMethod.GetById )
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
				SdhMonPhanCongNhieuGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhMonPhanCongNhieuGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhMonPhanCongNhieuGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhMonPhanCongNhieuGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhMonPhanCongNhieuGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhMonPhanCongNhieuGiangVienDataSource class.
	/// </summary>
	public class SdhMonPhanCongNhieuGiangVienDataSourceDesigner : ProviderDataSourceDesigner<SdhMonPhanCongNhieuGiangVien, SdhMonPhanCongNhieuGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienDataSourceDesigner class.
		/// </summary>
		public SdhMonPhanCongNhieuGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhMonPhanCongNhieuGiangVienSelectMethod SelectMethod
		{
			get { return ((SdhMonPhanCongNhieuGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhMonPhanCongNhieuGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhMonPhanCongNhieuGiangVienDataSourceActionList

	/// <summary>
	/// Supports the SdhMonPhanCongNhieuGiangVienDataSourceDesigner class.
	/// </summary>
	internal class SdhMonPhanCongNhieuGiangVienDataSourceActionList : DesignerActionList
	{
		private SdhMonPhanCongNhieuGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhMonPhanCongNhieuGiangVienDataSourceActionList(SdhMonPhanCongNhieuGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhMonPhanCongNhieuGiangVienSelectMethod SelectMethod
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

	#endregion SdhMonPhanCongNhieuGiangVienDataSourceActionList
	
	#endregion SdhMonPhanCongNhieuGiangVienDataSourceDesigner
	
	#region SdhMonPhanCongNhieuGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhMonPhanCongNhieuGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum SdhMonPhanCongNhieuGiangVienSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById
	}
	
	#endregion SdhMonPhanCongNhieuGiangVienSelectMethod

	#region SdhMonPhanCongNhieuGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhMonPhanCongNhieuGiangVienFilter : SqlFilter<SdhMonPhanCongNhieuGiangVienColumn>
	{
	}
	
	#endregion SdhMonPhanCongNhieuGiangVienFilter

	#region SdhMonPhanCongNhieuGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhMonPhanCongNhieuGiangVienExpressionBuilder : SqlExpressionBuilder<SdhMonPhanCongNhieuGiangVienColumn>
	{
	}
	
	#endregion SdhMonPhanCongNhieuGiangVienExpressionBuilder	

	#region SdhMonPhanCongNhieuGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhMonPhanCongNhieuGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhMonPhanCongNhieuGiangVienProperty : ChildEntityProperty<SdhMonPhanCongNhieuGiangVienChildEntityTypes>
	{
	}
	
	#endregion SdhMonPhanCongNhieuGiangVienProperty
}

