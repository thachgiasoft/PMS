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
	/// Represents the DataRepository.MucDoHoanThanhNckhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MucDoHoanThanhNckhDataSourceDesigner))]
	public class MucDoHoanThanhNckhDataSource : ProviderDataSource<MucDoHoanThanhNckh, MucDoHoanThanhNckhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MucDoHoanThanhNckhDataSource class.
		/// </summary>
		public MucDoHoanThanhNckhDataSource() : base(new MucDoHoanThanhNckhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MucDoHoanThanhNckhDataSourceView used by the MucDoHoanThanhNckhDataSource.
		/// </summary>
		protected MucDoHoanThanhNckhDataSourceView MucDoHoanThanhNckhView
		{
			get { return ( View as MucDoHoanThanhNckhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MucDoHoanThanhNckhDataSource control invokes to retrieve data.
		/// </summary>
		public MucDoHoanThanhNckhSelectMethod SelectMethod
		{
			get
			{
				MucDoHoanThanhNckhSelectMethod selectMethod = MucDoHoanThanhNckhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MucDoHoanThanhNckhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MucDoHoanThanhNckhDataSourceView class that is to be
		/// used by the MucDoHoanThanhNckhDataSource.
		/// </summary>
		/// <returns>An instance of the MucDoHoanThanhNckhDataSourceView class.</returns>
		protected override BaseDataSourceView<MucDoHoanThanhNckh, MucDoHoanThanhNckhKey> GetNewDataSourceView()
		{
			return new MucDoHoanThanhNckhDataSourceView(this, DefaultViewName);
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
	/// Supports the MucDoHoanThanhNckhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MucDoHoanThanhNckhDataSourceView : ProviderDataSourceView<MucDoHoanThanhNckh, MucDoHoanThanhNckhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MucDoHoanThanhNckhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MucDoHoanThanhNckhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MucDoHoanThanhNckhDataSourceView(MucDoHoanThanhNckhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MucDoHoanThanhNckhDataSource MucDoHoanThanhNckhOwner
		{
			get { return Owner as MucDoHoanThanhNckhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MucDoHoanThanhNckhSelectMethod SelectMethod
		{
			get { return MucDoHoanThanhNckhOwner.SelectMethod; }
			set { MucDoHoanThanhNckhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MucDoHoanThanhNckhService MucDoHoanThanhNckhProvider
		{
			get { return Provider as MucDoHoanThanhNckhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MucDoHoanThanhNckh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MucDoHoanThanhNckh> results = null;
			MucDoHoanThanhNckh item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case MucDoHoanThanhNckhSelectMethod.Get:
					MucDoHoanThanhNckhKey entityKey  = new MucDoHoanThanhNckhKey();
					entityKey.Load(values);
					item = MucDoHoanThanhNckhProvider.Get(entityKey);
					results = new TList<MucDoHoanThanhNckh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MucDoHoanThanhNckhSelectMethod.GetAll:
                    results = MucDoHoanThanhNckhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MucDoHoanThanhNckhSelectMethod.GetPaged:
					results = MucDoHoanThanhNckhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MucDoHoanThanhNckhSelectMethod.Find:
					if ( FilterParameters != null )
						results = MucDoHoanThanhNckhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MucDoHoanThanhNckhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MucDoHoanThanhNckhSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = MucDoHoanThanhNckhProvider.GetById(_id);
					results = new TList<MucDoHoanThanhNckh>();
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
			if ( SelectMethod == MucDoHoanThanhNckhSelectMethod.Get || SelectMethod == MucDoHoanThanhNckhSelectMethod.GetById )
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
				MucDoHoanThanhNckh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MucDoHoanThanhNckhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MucDoHoanThanhNckh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MucDoHoanThanhNckhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MucDoHoanThanhNckhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MucDoHoanThanhNckhDataSource class.
	/// </summary>
	public class MucDoHoanThanhNckhDataSourceDesigner : ProviderDataSourceDesigner<MucDoHoanThanhNckh, MucDoHoanThanhNckhKey>
	{
		/// <summary>
		/// Initializes a new instance of the MucDoHoanThanhNckhDataSourceDesigner class.
		/// </summary>
		public MucDoHoanThanhNckhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MucDoHoanThanhNckhSelectMethod SelectMethod
		{
			get { return ((MucDoHoanThanhNckhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MucDoHoanThanhNckhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MucDoHoanThanhNckhDataSourceActionList

	/// <summary>
	/// Supports the MucDoHoanThanhNckhDataSourceDesigner class.
	/// </summary>
	internal class MucDoHoanThanhNckhDataSourceActionList : DesignerActionList
	{
		private MucDoHoanThanhNckhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MucDoHoanThanhNckhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MucDoHoanThanhNckhDataSourceActionList(MucDoHoanThanhNckhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MucDoHoanThanhNckhSelectMethod SelectMethod
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

	#endregion MucDoHoanThanhNckhDataSourceActionList
	
	#endregion MucDoHoanThanhNckhDataSourceDesigner
	
	#region MucDoHoanThanhNckhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MucDoHoanThanhNckhDataSource.SelectMethod property.
	/// </summary>
	public enum MucDoHoanThanhNckhSelectMethod
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
	
	#endregion MucDoHoanThanhNckhSelectMethod

	#region MucDoHoanThanhNckhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MucDoHoanThanhNckh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MucDoHoanThanhNckhFilter : SqlFilter<MucDoHoanThanhNckhColumn>
	{
	}
	
	#endregion MucDoHoanThanhNckhFilter

	#region MucDoHoanThanhNckhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MucDoHoanThanhNckh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MucDoHoanThanhNckhExpressionBuilder : SqlExpressionBuilder<MucDoHoanThanhNckhColumn>
	{
	}
	
	#endregion MucDoHoanThanhNckhExpressionBuilder	

	#region MucDoHoanThanhNckhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MucDoHoanThanhNckhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MucDoHoanThanhNckh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MucDoHoanThanhNckhProperty : ChildEntityProperty<MucDoHoanThanhNckhChildEntityTypes>
	{
	}
	
	#endregion MucDoHoanThanhNckhProperty
}

