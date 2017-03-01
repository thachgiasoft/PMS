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
	/// Represents the DataRepository.SdhNhomMonHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhNhomMonHocDataSourceDesigner))]
	public class SdhNhomMonHocDataSource : ProviderDataSource<SdhNhomMonHoc, SdhNhomMonHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhNhomMonHocDataSource class.
		/// </summary>
		public SdhNhomMonHocDataSource() : base(new SdhNhomMonHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhNhomMonHocDataSourceView used by the SdhNhomMonHocDataSource.
		/// </summary>
		protected SdhNhomMonHocDataSourceView SdhNhomMonHocView
		{
			get { return ( View as SdhNhomMonHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhNhomMonHocDataSource control invokes to retrieve data.
		/// </summary>
		public SdhNhomMonHocSelectMethod SelectMethod
		{
			get
			{
				SdhNhomMonHocSelectMethod selectMethod = SdhNhomMonHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhNhomMonHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhNhomMonHocDataSourceView class that is to be
		/// used by the SdhNhomMonHocDataSource.
		/// </summary>
		/// <returns>An instance of the SdhNhomMonHocDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhNhomMonHoc, SdhNhomMonHocKey> GetNewDataSourceView()
		{
			return new SdhNhomMonHocDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhNhomMonHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhNhomMonHocDataSourceView : ProviderDataSourceView<SdhNhomMonHoc, SdhNhomMonHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhNhomMonHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhNhomMonHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhNhomMonHocDataSourceView(SdhNhomMonHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhNhomMonHocDataSource SdhNhomMonHocOwner
		{
			get { return Owner as SdhNhomMonHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhNhomMonHocSelectMethod SelectMethod
		{
			get { return SdhNhomMonHocOwner.SelectMethod; }
			set { SdhNhomMonHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhNhomMonHocService SdhNhomMonHocProvider
		{
			get { return Provider as SdhNhomMonHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhNhomMonHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhNhomMonHoc> results = null;
			SdhNhomMonHoc item;
			count = 0;
			
			System.Int32 _maNhomMon;

			switch ( SelectMethod )
			{
				case SdhNhomMonHocSelectMethod.Get:
					SdhNhomMonHocKey entityKey  = new SdhNhomMonHocKey();
					entityKey.Load(values);
					item = SdhNhomMonHocProvider.Get(entityKey);
					results = new TList<SdhNhomMonHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhNhomMonHocSelectMethod.GetAll:
                    results = SdhNhomMonHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhNhomMonHocSelectMethod.GetPaged:
					results = SdhNhomMonHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhNhomMonHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhNhomMonHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhNhomMonHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhNhomMonHocSelectMethod.GetByMaNhomMon:
					_maNhomMon = ( values["MaNhomMon"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhomMon"], typeof(System.Int32)) : (int)0;
					item = SdhNhomMonHocProvider.GetByMaNhomMon(_maNhomMon);
					results = new TList<SdhNhomMonHoc>();
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
			if ( SelectMethod == SdhNhomMonHocSelectMethod.Get || SelectMethod == SdhNhomMonHocSelectMethod.GetByMaNhomMon )
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
				SdhNhomMonHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhNhomMonHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhNhomMonHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhNhomMonHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhNhomMonHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhNhomMonHocDataSource class.
	/// </summary>
	public class SdhNhomMonHocDataSourceDesigner : ProviderDataSourceDesigner<SdhNhomMonHoc, SdhNhomMonHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhNhomMonHocDataSourceDesigner class.
		/// </summary>
		public SdhNhomMonHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhNhomMonHocSelectMethod SelectMethod
		{
			get { return ((SdhNhomMonHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhNhomMonHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhNhomMonHocDataSourceActionList

	/// <summary>
	/// Supports the SdhNhomMonHocDataSourceDesigner class.
	/// </summary>
	internal class SdhNhomMonHocDataSourceActionList : DesignerActionList
	{
		private SdhNhomMonHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhNhomMonHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhNhomMonHocDataSourceActionList(SdhNhomMonHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhNhomMonHocSelectMethod SelectMethod
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

	#endregion SdhNhomMonHocDataSourceActionList
	
	#endregion SdhNhomMonHocDataSourceDesigner
	
	#region SdhNhomMonHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhNhomMonHocDataSource.SelectMethod property.
	/// </summary>
	public enum SdhNhomMonHocSelectMethod
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
		/// Represents the GetByMaNhomMon method.
		/// </summary>
		GetByMaNhomMon
	}
	
	#endregion SdhNhomMonHocSelectMethod

	#region SdhNhomMonHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhNhomMonHocFilter : SqlFilter<SdhNhomMonHocColumn>
	{
	}
	
	#endregion SdhNhomMonHocFilter

	#region SdhNhomMonHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhNhomMonHocExpressionBuilder : SqlExpressionBuilder<SdhNhomMonHocColumn>
	{
	}
	
	#endregion SdhNhomMonHocExpressionBuilder	

	#region SdhNhomMonHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhNhomMonHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhNhomMonHocProperty : ChildEntityProperty<SdhNhomMonHocChildEntityTypes>
	{
	}
	
	#endregion SdhNhomMonHocProperty
}

