using Cake.Core.IO;

namespace Cake.ImageMagick
{
    /// <summary>
    /// Settings for ImageMagick convert
    /// </summary>
    public sealed class ImageMagickConvertSettings: AutoToolSettings
    {
        /// <summary>
        /// adaptively blur pixels; decrease effect near edges
        /// </summary>
        public RadiusSigma? AdaptiveBlur { get; set; }
        /// <summary>
        /// adaptively resize image with data dependent triangulation.
        /// </summary>
        public Geometry AdaptiveResize { get; set; }
        /// <summary>
        /// adaptively sharpen pixels; increase effect near edges
        /// </summary>
        public RadiusSigma? AdaptiveSharpen { get; set; }
        /// <summary>
        /// join images into a single multi-image file
        /// </summary>
        public bool? Adjoin { get; set; }
        /// <summary>
        /// affine transform matrix
        /// </summary>
        public Affine? Affine { get; set; }
        /// <summary>
        /// Activate, off, deactivate, set, opaque, copy, transparent, extract, background, or shape the alpha channel
        /// </summary>
        public Alpha? Alpha { get; set; }
        /// <summary>
        /// Specify the color to be used with the -frame option
        /// </summary>
        public string AlphaColor { get; set; }
        /// <summary>
        ///    annotate the image with text
        /// </summary>
        public Annotate? Annotate { get; set; }
        /// <summary>
        /// remove pixel-aliasing
        /// </summary>
        [Bool(Options = Options.PlusMinus)]
        public bool? Antialias { get; set; }
        /// <summary>
        ///    append an image sequence
        /// </summary>
        [Bool(Options = Options.PlusMinus)]
        public bool? Append { get; set; }
        /// <summary>
        /// Lessen (or intensify) when adding noise to an image
        /// </summary>
        public decimal? Attenuate { get; set; }
        /// <summary>
        /// authenticate value decipher image with this password
        /// </summary>
        public string Authenticate { get; set; }
        /// <summary>
        ///    automagically adjust gamma level of image
        /// </summary>
        public bool? AutoGamma { get; set; }
        /// <summary>
        ///    automagically adjust color levels of image
        /// </summary>
        public bool? AutoLevel { get; set; }
        /// <summary>
        ///   automagically orient image
        /// </summary>
        public bool? AutoOrient { get; set; }
        /// <summary>
        /// Average a set of images
        /// </summary>
        public bool? Average { get; set; }
        /// <summary>
        /// Display the image centered on a backdrop
        /// </summary>
        public bool? Backdrop { get; set; }
        /// <summary>
        /// background color background color
        /// </summary>
        public string Background { get; set; }
        ///// <summary>
        ///// bench iterations measure performance
        ///// </summary>
        //public bool? Bench { get; set; }
        /// <summary>
        /// bias value add bias when convolving an image
        /// </summary>
        public RelativeInt? Bias { get; set; }
        /// <summary>
        /// Use black point compensation
        /// </summary>
        public bool? BlackPointCompensation { get; set; }
        /// <summary>
        /// black-threshold value force all pixels below the threshold into black
        /// </summary>
        public RelativeInt? BlackThreshold { get; set; }
        /// <summary>
        /// blend an image into another by the given absolute value or percent
        /// </summary>
        public Geometry Blend { get; set; }
        /// <summary>
        /// blue-primary point chromaticity blue primary point
        /// </summary>
        public Point? BluePrimary { get; set; }
        /// <summary>
        /// blue-shift factor simulate a scene at nighttime in the moonlight
        /// </summary>
        public decimal? BlueShift { get; set; }
        /// <summary>
        /// blur geometry reduce image noise and reduce detail levels
        /// </summary>
        public Blur? Blur { get; set; }
        /// <summary>
        /// border geometry surround image with a border of color
        /// </summary>
        public Geometry Border { get; set; }
        /// <summary>
        /// bordercolor color border color
        /// </summary>
        public string Bordercolor { get; set; }
        /// <summary>
        /// Set the border width
        /// </summary>
        public Geometry BorderWidth { get; set; }
        /// <summary>
        /// brightness-contrast geometry improve brightness / contrast of the image
        /// </summary>
        public BrightnessContrast? BrightnessContrast { get; set; }
        /// <summary>
        /// canny geometry use a multi-stage algorithm to detect a wide range of edges in the image
        /// </summary>
        public Canny? Canny { get; set; }
        /// <summary>
        /// caption string assign a caption to an image
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// cdl filename color correct with a color decision list
        /// </summary>
        public FilePath Cdl { get; set; }
        /// <summary>
        /// channel type apply option to select image channels
        /// </summary>
        public Channel[] Channel { get; set; }
        /// <summary>
        /// charcoal radius simulate a charcoal drawing
        /// </summary>
        public decimal? Charcoal { get; set; }
        /// <summary>
        /// chop geometry remove pixels from the image interior
        /// </summary>
        public Geometry Chop { get; set; }
        /// <summary>
        /// set each pixel whose value is below zero to zero and any the pixel whose value is above the quantum range to the quantum range(e.g. 65535) otherwise the pixel value remains unchanged.
        /// </summary>
        public bool? Clamp { get; set; }
        /// <summary>
        /// clip clip along the first path from the 8BIM profile
        /// </summary>
        [Bool(Options = Options.PlusMinus)]
        public bool? Clip { get; set; }
        /// <summary>
        ///    associate clip mask with the image
        /// </summary>
        [Bool(Options =  Options.PlusMinus)]
        public bool? ClipMask { get; set; }
        /// <summary>
        ///  clip along a named path from the 8BIM profile
        /// </summary>
        public ActiveString ClipPath { get; set; }
        /// <summary>
        ///   clone an image
        /// </summary>
        public ActiveInts Clone { get; set; }
        /// <summary>
        /// clut apply a color lookup table to the image
        /// </summary>
        public bool? Clut { get; set; }
        /// <summary>
        /// connected-components uniquely labeled, choose from 4 or 8 way connectivity
        /// </summary>
        public string ConnectedComponents { get; set; }
        ///// <summary>
        ///// improve the contrast in an image by `stretching' the range of intensity value
        ///// </summary>
        //public bool? ContrastStretch { get; set; }
        /// <summary>
        /// coalesce merge a sequence of images
        /// </summary>
        public bool? Coalesce { get; set; }
        /// <summary>
        ///    colorize the image with the fill color
        /// </summary>
        public int[] Colorize { get; set; }
        /// <summary>
        /// Define the colormap type
        /// </summary>
        public ColorMap? ColorMap { get; set; }
        /// <summary>
        ///   apply color correction to the image.
        /// </summary>
        /// TODO enhance type
        public string ColorMatrix { get; set; }
        /// <summary>
        ///  preferred number of colors in the image
        /// </summary>
        public int? Colors { get; set; }
        /// <summary>
        ///   set image colorspace
        /// </summary>
        public ColorSpace? Colorspace { get; set; }
        /// <summary>
        /// combine combine a sequence of images
        /// </summary>
        public bool? Combine { get; set; }
        /// <summary>
        /// comment string annotate image with comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// compare compare image
        /// </summary>
        public bool? Compare { get; set; }
        /// <summary>
        /// complexoperator perform complex mathematics on an image sequence
        /// </summary>
        public ComplexOperator? Complex { get; set; }
        /// <summary>
        /// set image composite operator
        /// </summary>
        /// TODO enhance type
        public string Compose { get; set; }
        /// <summary>
        /// composite composite image
        /// </summary>
        public bool? Composite { get; set; }
        /// <summary>
        /// image compression type
        /// </summary>
        public Compression? Compress { get; set; }
        /// <summary>
        /// contrast enhance or reduce the image contrast
        /// </summary>
        [Bool(Options = Options.PlusMinus)]
        public bool? Contrast { get; set; }
        /// <summary>
        /// apply a convolution kernel to the image
        /// </summary>
        public bool? Convolve { get; set; }
        /// <summary>
        /// copy geometry offset copy pixels from one area of an image to another
        /// </summary>
        public bool? Copy { get; set; }
        /// <summary>
        /// crop the image
        /// </summary>
        public bool? Crop { get; set; }
        /// <summary>
        ///  cycle the image colormap
        /// </summary>
        public bool? Cycle { get; set; }
        /// <summary>
        /// convert cipher pixels to plain
        /// </summary>
        public bool? Decipher { get; set; }
        /// <summary>
        ///  display copious debugging information
        /// </summary>
        public bool? Debug { get; set; }
        /// <summary>
        /// define format:option define one or more image format options
        /// </summary>
        public bool? Define { get; set; }
        /// <summary>
        ///   break down an image sequence into constituent parts
        /// </summary>
        public bool? Deconstruct { get; set; }
        /// <summary>
        ///   display the next image after pausing
        /// </summary>
        public bool? Delay { get; set; }
        /// <summary>
        ///  delete the image from the image sequence
        /// </summary>
        public bool? Delete { get; set; }
        /// <summary>
        ///  horizontal and vertical density of the image
        /// </summary>
        public bool? Density { get; set; }
        /// <summary>
        ///   image depth
        /// </summary>
        public bool? Depth { get; set; }
        /// <summary>
        /// despeckle reduce the speckles within an image
        /// </summary>
        public bool? Despeckle { get; set; }
        /// <summary>
        ///    render text right-to-left or left-to-right
        /// </summary>
        public bool? Direction { get; set; }
        /// <summary>
        ///    get image or font from this X server
        /// </summary>
        public bool? Display { get; set; }
        /// <summary>
        ///    layer disposal method
        /// </summary>
        public bool? Dispose { get; set; }
        /// <summary>
        /// launch a distributed pixel cache server
        /// </summary>
        public bool? DistributeCache { get; set; }
        /// <summary>
        /// distort type coefficients distort image
        /// </summary>
        public bool? Distort { get; set; }
        /// <summary>
        /// apply error diffusion to image
        /// </summary>
        public bool? Dither { get; set; }
        /// <summary>
        /// draw string annotate the image with a graphic primitive
        /// </summary>
        public bool? Draw { get; set; }
        /// <summary>
        /// duplicate count, indexes duplicate an image one or more times
        /// </summary>
        public bool? Duplicate { get; set; }
        /// <summary>
        ///   apply a filter to detect edges in the image
        /// </summary>
        public bool? Edge { get; set; }
        /// <summary>
        /// emboss an image
        /// </summary>
        public bool? Emboss { get; set; }
        /// <summary>
        /// convert plain pixels to cipher pixels
        /// </summary>
        public bool? Encipher { get; set; }
        /// <summary>
        /// text encoding type
        /// </summary>
        public bool? Encoding { get; set; }
        /// <summary>
        ///   endianness (MSB or LSB) of the image
        /// </summary>
        public bool? Endian { get; set; }
        /// <summary>
        ///   apply a digital filter to enhance a noisy image
        /// </summary>
        public bool? Enhance { get; set; }
        /// <summary>
        ///  perform histogram equalization to an image
        /// </summary>
        public bool? Equalize { get; set; }
        /// <summary>
        ///   evaluate an arithmetic, relational, or logical expression
        /// </summary>
        public bool? Evaluate { get; set; }
        /// <summary>
        /// evaluate an arithmetic, relational, or logical expression for an image sequence
        /// </summary>
        public bool? EvaluateSequence { get; set; }
        /// <summary>
        ///   set the image size
        /// </summary>
        public bool? Extent { get; set; }
        /// <summary>
        ///  extract area from image
        /// </summary>
        public bool? Extract { get; set; }
        /// <summary>
        ///   render text with this font family
        /// </summary>
        public bool? Family { get; set; }
        /// <summary>
        /// analyze image features (e.g.contract, correlations, etc.).
        /// </summary>
        public bool? Features { get; set; }
        /// <summary>
        ///   implements the discrete Fourier transform(DFT)
        /// </summary>
        public bool? Fft { get; set; }
        /// <summary>
        /// fill color color to use when filling a graphic primitive
        /// </summary>
        public bool? Fill { get; set; }
        /// <summary>
        /// filter type use this filter when resizing an image
        /// </summary>
        public bool? Filter { get; set; }
        /// <summary>
        ///   flatten a sequence of images
        /// </summary>
        public bool? Flatten { get; set; }
        /// <summary>
        ///  flip image in the vertical direction
        /// </summary>
        public bool? Flip { get; set; }
        /// <summary>
        ///  floodfill the image with color
        /// </summary>
        public bool? Floodfill { get; set; }
        /// <summary>
        ///  flop image in the horizontal direction
        /// </summary>
        public bool? Flop { get; set; }
        /// <summary>
        /// font name render text with this font
        /// </summary>
        public bool? Font { get; set; }
        /// <summary>
        /// format string output formatted image characteristics
        /// </summary>
        public bool? Format { get; set; }
        /// <summary>
        /// frame geometry surround image with an ornamental border
        /// </summary>
        public bool? Frame { get; set; }
        /// <summary>
        /// function name apply a function to the image
        /// </summary>
        public bool? Function { get; set; }
        /// <summary>
        /// fuzz distance colors within this distance are considered equal
        /// </summary>
        public bool? Fuzz { get; set; }
        /// <summary>
        /// fx expression apply mathematical expression to an image channel(s)
        /// </summary>
        public bool? Fx { get; set; }
        /// <summary>
        /// gamma value level of gamma correction
        /// </summary>
        public bool? Gamma { get; set; }
        /// <summary>
        /// gaussian-blur geometry reduce image noise and reduce detail levels
        /// </summary>
        public bool? GaussianBlur { get; set; }
        /// <summary>
        /// geometry geometry preferred size or location of the image
        /// </summary>
        public bool? Geometry { get; set; }
        /// <summary>
        /// gravity type horizontal and vertical text placement
        /// </summary>
        public bool? Gravity { get; set; }
        /// <summary>
        /// grayscale method convert image to grayscale
        /// </summary>
        public bool? Grayscale { get; set; }
        /// <summary>
        /// green-primary point chromaticity green primary point
        /// </summary>
        public bool? GreenPrimary { get; set; }
        /// <summary>
        ///  print program options
        /// </summary>
        public bool? Help { get; set; }
        /// <summary>
        /// hough-lines geometry identify lines in the image
        /// </summary>
        public bool? HoughLines { get; set; }
        /// <summary>
        ///  identify the format and characteristics of the image
        /// </summary>
        public bool? Identify { get; set; }
        /// <summary>
        ///   implements the inverse discrete Fourier transform(DFT)
        /// </summary>
        public bool? Ift { get; set; }
        /// <summary>
        /// implode amount implode image pixels about the center
        /// </summary>
        public bool? Implode { get; set; }
        /// <summary>
        /// insert index insert last image into the image sequence
        /// </summary>
        public bool? Insert { get; set; }
        /// <summary>
        /// intensity method method to generate an intensity value from a pixel
        /// </summary>
        public bool? Intensity { get; set; }
        /// <summary>
        /// intent type type of rendering intent when managing the image color
        /// </summary>
        public bool? Intent { get; set; }
        /// <summary>
        /// interlace type type of image interlacing scheme
        /// </summary>
        public bool? Interlace { get; set; }
        /// <summary>
        /// interline-spacing value the space between two text lines
        /// </summary>
        public bool? InterlineSpacing { get; set; }
        /// <summary>
        /// interpolate method pixel color interpolation method
        /// </summary>
        public bool? Interpolate { get; set; }
        /// <summary>
        /// interword-spacing value the space between two words
        /// </summary>
        public bool? InterwordSpacing { get; set; }
        /// <summary>
        /// kerning value the space between two characters
        /// </summary>
        public bool? Kerning { get; set; }
        /// <summary>
        /// kuwahara geometry edge preserving noise reduction filter
        /// </summary>
        public bool? Kuwahara { get; set; }
        /// <summary>
        /// label string assign a label to an image
        /// </summary>
        public bool? Label { get; set; }
        /// <summary>
        /// lat geometry local adaptive thresholding
        /// </summary>
        public bool? Lat { get; set; }
        /// <summary>
        /// layers method optimize or compare image layers
        /// </summary>
        public bool? Layers { get; set; }
        /// <summary>
        /// level value adjust the level of image contrast
        /// </summary>
        public bool? Level { get; set; }
        /// <summary>
        ///  pixel cache resource limit
        /// </summary>
        public bool? Limit { get; set; }
        /// <summary>
        /// linear-stretch geometry linear with saturation histogram stretch
        /// </summary>
        public bool? LinearStretch { get; set; }
        /// <summary>
        /// liquid-rescale geometry rescale image with seam-carving
        /// </summary>
        public bool? LiquidRescale { get; set; }
        /// <summary>
        /// list type Color, Configure, Delegate, Format, Magic, Module, Resource, or Type
        /// </summary>
        public bool? List { get; set; }
        /// <summary>
        /// log format format of debugging information
        /// </summary>
        public bool? Log { get; set; }
        /// <summary>
        /// loop iterations add Netscape loop extension to your GIF animation
        /// </summary>
        public bool? Loop { get; set; }
        /// <summary>
        /// mask filename associate a mask with the image
        /// </summary>
        public bool? Mask { get; set; }
        /// <summary>
        /// mattecolor color frame color
        /// </summary>
        public bool? Mattecolor { get; set; }
        /// <summary>
        /// median radius apply a median filter to the image
        /// </summary>
        public bool? Median { get; set; }
        /// <summary>
        /// mean-shift geometry delineate arbitrarily shaped clusters in the image
        /// </summary>
        public bool? MeanShift { get; set; }
        /// <summary>
        /// metric type measure differences between images with this metric
        /// </summary>
        public bool? Metric { get; set; }
        /// <summary>
        /// mode radius make each pixel the 'predominant color' of the neighborhood
        /// </summary>
        public bool? Mode { get; set; }
        /// <summary>
        /// modulate value vary the brightness, saturation, and hue
        /// </summary>
        public bool? Modulate { get; set; }
        /// <summary>
        ///   display image moments.
        /// </summary>
        public bool? Moments { get; set; }
        /// <summary>
        ///   monitor progress
        /// </summary>
        public bool? Monitor { get; set; }
        /// <summary>
        ///    transform image to black and white
        /// </summary>
        public bool? Monochrome { get; set; }
        /// <summary>
        /// morph value morph an image sequence
        /// </summary>
        public bool? Morph { get; set; }
        /// <summary>
        ///  apply a morphology method to the image
        /// </summary>
        public bool? Morphology { get; set; }
        /// <summary>
        /// motion-blur geometry simulate motion blur
        /// </summary>
        public bool? MotionBlur { get; set; }
        /// <summary>
        ///    replace each pixel with its complementary color
        /// </summary>
        public bool? Negate { get; set; }
        /// <summary>
        /// noise radius add or reduce noise in an image
        /// </summary>
        public bool? Noise { get; set; }
        /// <summary>
        /// transform image to span the full range of colors
        /// </summary>
        public bool? Normalize { get; set; }
        /// <summary>
        /// opaque color change this color to the fill color
        /// </summary>
        public bool? Opaque { get; set; }
        /// <summary>
        /// ordered-dither NxN ordered dither the image
        /// </summary>
        public bool? OrderedDither { get; set; }
        /// <summary>
        /// orient type image orientation
        /// </summary>
        public bool? Orient { get; set; }
        /// <summary>
        /// page geometry size and location of an image canvas(setting)
        /// </summary>
        public bool? Page { get; set; }
        /// <summary>
        /// paint radius simulate an oil painting
        /// </summary>
        public bool? Paint { get; set; }
        /// <summary>
        ///   set each pixel whose value is less than | epsilon | to-epsilon or epsilon(whichever is closer) otherwise the pixel value remains unchanged.
        /// </summary>
        public bool? Perceptible { get; set; }
        /// <summary>
        /// ping efficiently determine image attributes
        /// </summary>
        public bool? Ping { get; set; }
        /// <summary>
        ///   font point size
        /// </summary>
        public bool? Pointsize { get; set; }
        /// <summary>
        ///    simulate a Polaroid picture
        /// </summary>
        public bool? Polaroid { get; set; }
        /// <summary>
        ///    build a polynomial from the image sequence and the corresponding terms (coefficients and degree pairs).
        /// </summary>
        public bool? Poly { get; set; }
        /// <summary>
        /// posterize levels reduce the image to a limited number of color levels
        /// </summary>
        public bool? Posterize { get; set; }
        /// <summary>
        /// precision value set the maximum number of significant digits to be printed
        /// </summary>
        public bool? Precision { get; set; }
        /// <summary>
        /// preview type image preview type
        /// </summary>
        public bool? Preview { get; set; }
        /// <summary>
        /// print string interpret string and print to console
        /// </summary>
        public bool? Print { get; set; }
        /// <summary>
        ///  process the image with a custom image filter
        /// </summary>
        public bool? Process { get; set; }
        /// <summary>
        /// profile filename add, delete, or apply an image profile
        /// </summary>
        public bool? Profile { get; set; }
        /// <summary>
        /// quality value JPEG/ MIFF / PNG compression level
        /// </summary>
        public bool? Quality { get; set; }
        /// <summary>
        /// quantize colorspace reduce image colors in this colorspace
        /// </summary>
        public bool? Quantize { get; set; }
        /// <summary>
        /// suppress all warning messages
        /// </summary>
        public bool? Quiet { get; set; }
        /// <summary>
        /// radial-blur angle radial blur the image
        /// </summary>
        public bool? RadialBlur { get; set; }
        /// <summary>
        /// raise value lighten/ darken image edges to create a 3-D effect
        /// </summary>
        public bool? Raise { get; set; }
        /// <summary>
        /// random-threshold low,high random threshold the image
        /// </summary>
        public bool? RandomThreshold { get; set; }
        /// <summary>
        /// red-primary point chromaticity red primary point
        /// </summary>
        public bool? RedPrimary { get; set; }
        /// <summary>
        ///   pay attention to warning messages.
        /// </summary>
        public bool? RegardWarnings { get; set; }
        /// <summary>
        /// region geometry apply options to a portion of the image
        /// </summary>
        public bool? Region { get; set; }
        /// <summary>
        /// remap filename transform image colors to match this set of colors
        /// </summary>
        public bool? Remap { get; set; }
        /// <summary>
        ///    render vector graphics
        /// </summary>
        public bool? Render { get; set; }
        /// <summary>
        /// repage geometry size and location of an image canvas
        /// </summary>
        public bool? Repage { get; set; }
        /// <summary>
        /// resample geometry change the resolution of an image
        /// </summary>
        public bool? Resample { get; set; }
        /// <summary>
        /// resize geometry resize the image
        /// </summary>
        public bool? Resize { get; set; }
        /// <summary>
        ///   settings remain in effect until parenthesis boundary.
        /// </summary>
        public bool? RespectParentheses { get; set; }
        /// <summary>
        /// roll an image vertically or horizontally
        /// </summary>
        public bool? Roll { get; set; }
        /// <summary>
        ///    apply Paeth rotation to the image
        /// </summary>
        public bool? Rotate { get; set; }
        /// <summary>
        ///   scale image with pixel sampling
        /// </summary>
        public bool? Sample { get; set; }
        /// <summary>
        ///  horizontal and vertical sampling factor
        /// </summary>
        public bool? SamplingFactor { get; set; }
        /// <summary>
        ///    scale the image
        /// </summary>
        public bool? Scale { get; set; }
        /// <summary>
        ///   image scene number
        /// </summary>
        public bool? Scene { get; set; }
        /// <summary>
        ///    seed a new sequence of pseudo-random numbers
        /// </summary>
        public bool? Seed { get; set; }
        /// <summary>
        /// segment an image
        /// </summary>
        public bool? Segment { get; set; }
        /// <summary>
        /// selectively blur pixels within a contrast threshold
        /// </summary>
        public bool? SelectiveBlur { get; set; }
        /// <summary>
        /// separate an image channel into a grayscale image
        /// </summary>
        public bool? Separate { get; set; }
        /// <summary>
        /// simulate a sepia-toned photo
        /// </summary>
        public bool? SepiaTone { get; set; }
        /// <summary>
        /// set an image attribute
        /// </summary>
        public bool? Set { get; set; }
        /// <summary>
        /// shade the image using a distant light source
        /// </summary>
        public bool? Shade { get; set; }
        /// <summary>
        /// shadow geometry simulate an image shadow
        /// </summary>
        public bool? Shadow { get; set; }
        /// <summary>
        /// sharpen geometry sharpen the image
        /// </summary>
        public bool? Sharpen { get; set; }
        /// <summary>
        /// shave geometry shave pixels from the image edges
        /// </summary>
        public bool? Shave { get; set; }
        /// <summary>
        /// shear geometry slide one edge of the image along the X or Y axis
        /// </summary>
        public bool? Shear { get; set; }
        /// <summary>
        /// sigmoidal-contrast geometry increase the contrast without saturating highlights or shadows
        /// </summary>
        public bool? SigmoidalContrast { get; set; }
        /// <summary>
        /// smush offset smush an image sequence together
        /// </summary>
        public bool? Smush { get; set; }
        /// <summary>
        /// size geometry width and height of image
        /// </summary>
        public bool? Size { get; set; }
        /// <summary>
        /// sketch geometry simulate a pencil sketch
        /// </summary>
        public bool? Sketch { get; set; }
        /// <summary>
        /// solarize threshold negate all pixels above the threshold level
        /// </summary>
        public bool? Solarize { get; set; }
        /// <summary>
        /// splice geometry splice the background color into the image
        /// </summary>
        public bool? Splice { get; set; }
        /// <summary>
        /// spread radius displace image pixels by a random amount
        /// </summary>
        public bool? Spread { get; set; }
        /// <summary>
        ///   replace each pixel with corresponding statistic from the neighborhood
        /// </summary>
        public bool? Statistic { get; set; }
        /// <summary>
        /// strip image of all profiles and comments
        /// </summary>
        public bool? Strip { get; set; }
        /// <summary>
        /// stroke color graphic primitive stroke color
        /// </summary>
        public bool? Stroke { get; set; }
        /// <summary>
        /// strokewidth value graphic primitive stroke width
        /// </summary>
        public bool? Strokewidth { get; set; }
        /// <summary>
        /// stretch type render text with this font stretch
        /// </summary>
        public bool? Stretch { get; set; }
        /// <summary>
        /// style type render text with this font style
        /// </summary>
        public bool? Style { get; set; }
        /// <summary>
        /// swap indexes swap two images in the image sequence
        /// </summary>
        public bool? Swap { get; set; }
        /// <summary>
        /// swirl degrees swirl image pixels about the center
        /// </summary>
        public bool? Swirl { get; set; }
        /// <summary>
        ///   synchronize image to storage device
        /// </summary>
        public bool? Synchronize { get; set; }
        /// <summary>
        /// mark the image as modified
        /// </summary>
        public bool? Taint { get; set; }
        /// <summary>
        /// texture filename name of texture to tile onto the image background
        /// </summary>
        public bool? Texture { get; set; }
        /// <summary>
        /// threshold value threshold the image
        /// </summary>
        public bool? Threshold { get; set; }
        /// <summary>
        /// thumbnail geometry create a thumbnail of the image
        /// </summary>
        public bool? Thumbnail { get; set; }
        /// <summary>
        /// tile filename tile image when filling a graphic primitive
        /// </summary>
        public bool? Tile { get; set; }
        /// <summary>
        /// tile-offset geometry set the image tile offset
        /// </summary>
        public bool? TileOffset { get; set; }
        /// <summary>
        /// tint value tint the image with the fill color
        /// </summary>
        public bool? Tint { get; set; }
        /// <summary>
        /// affine transform image
        /// </summary>
        public bool? Transform { get; set; }
        /// <summary>
        /// transparent color make this color transparent within the image
        /// </summary>
        public bool? Transparent { get; set; }
        /// <summary>
        /// transparent-color color transparent color
        /// </summary>
        public bool? TransparentColor { get; set; }
        /// <summary>
        /// flip image in the vertical direction and rotate 90 degrees
        /// </summary>
        public bool? Transpose { get; set; }
        /// <summary>
        ///    flop image in the horizontal direction and rotate 270 degrees
        /// </summary>
        public bool? Transverse { get; set; }
        /// <summary>
        /// treedepth value color tree depth
        /// </summary>
        public bool? Treedepth { get; set; }
        /// <summary>
        ///  trim image edges
        /// </summary>
        public bool? Trim { get; set; }
        /// <summary>
        /// type type image type
        /// </summary>
        public bool? Type { get; set; }
        /// <summary>
        /// undercolor color annotation bounding box color
        /// </summary>
        public bool? Undercolor { get; set; }
        /// <summary>
        /// discard all but one of any pixel color.
        /// </summary>
        public bool? UniqueColors { get; set; }
        /// <summary>
        ///    the units of image resolution
        /// </summary>
        public bool? Units { get; set; }
        /// <summary>
        ///  sharpen the image
        /// </summary>
        public bool? Unsharp { get; set; }
        /// <summary>
        /// verbose print detailed information about the image
        /// </summary>
        public bool? Verbose { get; set; }
        /// <summary>
        /// version print version information
        /// </summary>
        public bool? Version { get; set; }
        /// <summary>
        /// view FlashPix viewing transforms
        /// </summary>
        public bool? View { get; set; }
        /// <summary>
        /// soften the edges of the image in vignette style
        /// </summary>
        public bool? Vignette { get; set; }
        /// <summary>
        ///  access method for pixels outside the boundaries of the image
        /// </summary>
        public bool? VirtualPixel { get; set; }
        /// <summary>
        /// alter an image along a sine wave
        /// </summary>
        public bool? Wave { get; set; }
        /// <summary>
        /// removes noise from the image using a wavelet transform
        /// </summary>
        public bool? WaveletDenoise { get; set; }
        /// <summary>
        /// weight type render text with this font weight
        /// </summary>
        public bool? Weight { get; set; }
        /// <summary>
        /// white-point point chromaticity white point
        /// </summary>
        public bool? WhitePoint { get; set; }
        /// <summary>
        /// white-threshold value force all pixels above the threshold into white
        /// </summary>
        public bool? WhiteThreshold { get; set; }
        /// <summary>
        /// write filename write images to this file
        /// </summary>
        public bool? Write { get; set; }


    }
}
