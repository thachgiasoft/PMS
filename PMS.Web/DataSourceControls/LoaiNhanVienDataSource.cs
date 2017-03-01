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
	/// Represents the DataRepository.LoaiNhanVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LoaiNhanVienDataSourceDesigner))]
	public class LoaiNhanVienDataSource : ProviderDataSource<LoaiNhanVien, LoaiNhanVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienDataSource class.
		/// </summary>
		public LoaiNhanVienDataSource() : base(new LoaiNhanVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LoaiNhanVienDataSourceView used by the LoaiNhanVienDataSource.
		/// </summary>
		protected LoaiNhanVienDataSourceView LoaiNhanVienView
		{
			get { return ( View as LoaiNhanVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LoaiNhanVienDataSource control invokes to retrieve data.
		/// </summary>
		public LoaiNhanVienSelectMethod SelectMethod
		{
			get
			{
				LoaiNhanVienSelectMethod selectMethod = LoaiNhanVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LoaiNhanVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LoaiNhanVienDataSourceView class that is to be
		/// used by the LoaiNhanVienDataSource.
		/// </summary>
		/// <returns>An instance of the LoaiNhanVienDataSourceView class.</returns>
		protected override BaseDataSourceView<LoaiNhanVien, LoaiNhanVienKey> GetNewDataSourceView()
		{
			return new LoaiNhanVienDataSourceView(this, DefaultViewName);
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
	/// Supports the LoaiNhanVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LoaiNhanVienDataSourceView : ProviderDataSourceView<LoaiNhanVien, LoaiNhanVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LoaiNhanVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LoaiNhanVienDataSourceView(LoaiNhanVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LoaiNhanVienDataSource LoaiNhanVienOwner
		{
			get { return Owner as LoaiNhanVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LoaiNhanVienSelectMethod SelectMethod
		{
			get { return LoaiNhanVienOwner.SelectMethod; }
			set { LoaiNhanVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LoaiNhanVienService LoaiNhanVienProvider
		{
			get { return Provider as LoaiNhanVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LoaiNhanVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LoaiNhanVien> results = null;
			LoaiNhanVien item;
			count = 0;
			
			System.Int32 _maLoaiNhanVien;

			switch ( SelectMethod )
			{
				case LoaiNhanVienSelectMethod.Get:
					LoaiNhanVienKey entityKey  = new LoaiNhanVienKey();
					entityKey.Load(values);
					item = LoaiNhanVienProvider.Get(entityKey);
					results = new TList<LoaiNhanVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LoaiNhanVienSelectMethod.GetAll:
                    results = LoaiNhanVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LoaiNhanVienSelectMethod.GetPaged:
					results = LoaiNhanVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LoaiNhanVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = LoaiNhanVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LoaiNhanVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LoaiNhanVienSelectMethod.GetByMaLoaiNhanVien:
					_maLoaiNhanVien = ( values["MaLoaiNhanVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaLoaiNhanVien"], typeof(System.Int32)) : (int)0;
					item = LoaiNhanVienProvider.GetByMaLoaiNhanVien(_maLoaiNhanVien);
					results = new TList<LoaiNhanVien>();
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
			if ( SelectMethod == LoaiNhanVienSelectMethod.Get || SelectMethod == LoaiNhanVienSelectMethod.GetByMaLoaiNhanVien )
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
				LoaiNhanVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LoaiNhanVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LoaiNhanVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LoaiNhanVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LoaiNhanVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LoaiNhanVienDataSource class.
	/// </summary>
	public class LoaiNhanVienDataSourceDesigner : ProviderDataSourceDesigner<LoaiNhanVien, LoaiNhanVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienDataSourceDesigner class.
		/// </summary>
		public LoaiNhanVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LoaiNhanVienSelectMethod SelectMethod
		{
			get { return ((LoaiNhanVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LoaiNhanVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LoaiNhanVienDataSourceActionList

	/// <summary>
	/// Supports the LoaiNhanVienDataSourceDesigner class.
	/// </summary>
	internal class LoaiNhanVienDataSourceActionList : DesignerActionList
	{
		private LoaiNhanVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LoaiNhanVienDataSourceActionList(LoaiNhanVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LoaiNhanVienSelectMethod SelectMethod
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

	#endregion LoaiNhanVienDataSourceActionList
	
	#endregion LoaiNhanVienDataSourceDesigner
	
	#region LoaiNhanVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LoaiNhanVienDataSource.SelectMethod property.
	/// </summary>
	public enum LoaiNhanVienSelectMethod
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
		/// Represents the GetByMaLoaiNhanVien method.
		/// </summary>
		GetByMaLoaiNhanVien
	}
	
	#endregion LoaiNhanVienSelectMethod

	#region LoaiNhanVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiNhanVienFilter : SqlFilter<LoaiNhanVienColumn>
	{
	}
	
	#endregion LoaiNhanVienFilter

	#region LoaiNhanVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiNhanVienExpressionBuilder : SqlExpressionBuilder<LoaiNhanVienColumn>
	{
	}
	
	#endregion LoaiNhanVienExpressionBuilder	

	#region LoaiNhanVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LoaiNhanVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiNhanVienProperty : ChildEntityProperty<LoaiNhanVienChildEntityTypes>
	{
	}
	
	#endregion LoaiNhanVienProperty
}

