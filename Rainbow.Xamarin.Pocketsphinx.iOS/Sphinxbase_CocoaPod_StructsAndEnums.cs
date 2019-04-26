//using System;
//using System.Runtime.InteropServices;
//using Darwin;
//using Sphinxbase_CocoaPod;

//[StructLayout (LayoutKind.Explicit)]
//public struct anytype_t
//{
//	[FieldOffset (0)]
//	public unsafe void* ptr;

//	[FieldOffset (0)]
//	public nint i;

//	[FieldOffset (0)]
//	public nuint ui;

//	[FieldOffset (0)]
//	public double fl;
//}

//static class CFunctions
//{
//	// extern ad_rec_t * ad_open_dev (const char *dev, int32 samples_per_sec);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ad_rec_t* ad_open_dev (sbyte* dev, int samples_per_sec);

//	// extern ad_rec_t * ad_open_sps (int32 samples_per_sec);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ad_rec_t* ad_open_sps (int samples_per_sec);

//	// extern ad_rec_t * ad_open ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ad_rec_t* ad_open ();

//	// extern int32 ad_start_rec (ad_rec_t *);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ad_start_rec (ad_rec_t*);

//	// extern int32 ad_stop_rec (ad_rec_t *);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ad_stop_rec (ad_rec_t*);

//	// extern int32 ad_close (ad_rec_t *);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ad_close (ad_rec_t*);

//	// extern int32 ad_read (ad_rec_t *, int16 *buf, int32 max);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ad_read (ad_rec_t*, short* buf, int max);

//	// extern cmd_ln_t * cmd_ln_init (cmd_ln_t *inout_cmdln, const arg_t *defn, int32 strict, ...);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe cmd_ln_t* cmd_ln_init (cmd_ln_t* inout_cmdln, arg_t* defn, int strict, IntPtr varArgs);

//	// extern cmd_ln_t * cmd_ln_retain (cmd_ln_t *cmdln);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe cmd_ln_t* cmd_ln_retain (cmd_ln_t* cmdln);

//	// extern int cmd_ln_free_r (cmd_ln_t *cmdln);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int cmd_ln_free_r (cmd_ln_t* cmdln);

//	// extern cmd_ln_t * cmd_ln_parse_r (cmd_ln_t *inout_cmdln, const arg_t *defn, int32 argc, char **argv, int32 strict);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe cmd_ln_t* cmd_ln_parse_r (cmd_ln_t* inout_cmdln, arg_t* defn, int argc, sbyte*[] argv, int strict);

//	// extern cmd_ln_t * cmd_ln_parse_file_r (cmd_ln_t *inout_cmdln, const arg_t *defn, const char *filename, int32 strict);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe cmd_ln_t* cmd_ln_parse_file_r (cmd_ln_t* inout_cmdln, arg_t* defn, sbyte* filename, int strict);

//	// extern anytype_t * cmd_ln_access_r (cmd_ln_t *cmdln, const char *name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe anytype_t* cmd_ln_access_r (cmd_ln_t* cmdln, sbyte* name);

//	// extern const char * cmd_ln_str_r (cmd_ln_t *cmdln, const char *name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* cmd_ln_str_r (cmd_ln_t* cmdln, sbyte* name);

//	// extern const char ** cmd_ln_str_list_r (cmd_ln_t *cmdln, const char *name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte** cmd_ln_str_list_r (cmd_ln_t* cmdln, sbyte* name);

//	// extern long cmd_ln_int_r (cmd_ln_t *cmdln, const char *name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe nint cmd_ln_int_r (cmd_ln_t* cmdln, sbyte* name);

//	// extern double cmd_ln_float_r (cmd_ln_t *cmdln, const char *name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe double cmd_ln_float_r (cmd_ln_t* cmdln, sbyte* name);

//	// extern void cmd_ln_set_str_r (cmd_ln_t *cmdln, const char *name, const char *str);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmd_ln_set_str_r (cmd_ln_t* cmdln, sbyte* name, sbyte* str);

//	// extern void cmd_ln_set_str_extra_r (cmd_ln_t *cmdln, const char *name, const char *str);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmd_ln_set_str_extra_r (cmd_ln_t* cmdln, sbyte* name, sbyte* str);

//	// extern void cmd_ln_set_int_r (cmd_ln_t *cmdln, const char *name, long iv);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmd_ln_set_int_r (cmd_ln_t* cmdln, sbyte* name, nint iv);

//	// extern void cmd_ln_set_float_r (cmd_ln_t *cmdln, const char *name, double fv);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmd_ln_set_float_r (cmd_ln_t* cmdln, sbyte* name, double fv);

//	// extern int cmd_ln_exists_r (cmd_ln_t *cmdln, const char *name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int cmd_ln_exists_r (cmd_ln_t* cmdln, sbyte* name);

//	// extern void cmd_ln_print_help_r (cmd_ln_t *cmdln, FILE *fp, const arg_t *defn);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmd_ln_print_help_r (cmd_ln_t* cmdln, FILE* fp, arg_t* defn);

//	// extern void cmd_ln_print_values_r (cmd_ln_t *cmdln, FILE *fp, const arg_t *defn);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmd_ln_print_values_r (cmd_ln_t* cmdln, FILE* fp, arg_t* defn);

//	// extern int32 cmd_ln_parse (const arg_t *defn, int32 argc, char **argv, int32 strict);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int cmd_ln_parse (arg_t* defn, int argc, sbyte*[] argv, int strict);

//	// extern int32 cmd_ln_parse_file (const arg_t *defn, const char *filename, int32 strict);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int cmd_ln_parse_file (arg_t* defn, sbyte* filename, int strict);

//	// extern void cmd_ln_appl_enter (int argc, char **argv, const char *default_argfn, const arg_t *defn);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmd_ln_appl_enter (int argc, sbyte*[] argv, sbyte* default_argfn, arg_t* defn);

//	// extern void cmd_ln_appl_exit ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern void cmd_ln_appl_exit ();

//	// extern cmd_ln_t * cmd_ln_get ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe cmd_ln_t* cmd_ln_get ();

//	// extern void cmd_ln_free ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern void cmd_ln_free ();

//	// extern int32 fixlog (uint32 x);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern int fixlog (uint x);

//	// extern int32 fixlog2 (uint32 x);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern int fixlog2 (uint x);

//	// extern fe_t * fe_init_auto ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fe_t* fe_init_auto ();

//	// extern const arg_t * fe_get_args ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe arg_t* fe_get_args ();

//	// extern fe_t * fe_init_auto_r (cmd_ln_t *config);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fe_t* fe_init_auto_r (cmd_ln_t* config);

//	// extern const cmd_ln_t * fe_get_config (fe_t *fe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe cmd_ln_t* fe_get_config (fe_t* fe);

//	// extern void fe_start_stream (fe_t *fe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fe_start_stream (fe_t* fe);

//	// extern int fe_start_utt (fe_t *fe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_start_utt (fe_t* fe);

//	// extern int fe_get_output_size (fe_t *fe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_get_output_size (fe_t* fe);

//	// extern void fe_get_input_size (fe_t *fe, int *out_frame_shift, int *out_frame_size);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fe_get_input_size (fe_t* fe, int* out_frame_shift, int* out_frame_size);

//	// extern uint8 fe_get_vad_state (fe_t *fe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe byte fe_get_vad_state (fe_t* fe);

//	// extern int fe_end_utt (fe_t *fe, mfcc_t *out_cepvector, int32 *out_nframes);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_end_utt (fe_t* fe, float* out_cepvector, int* out_nframes);

//	// extern fe_t * fe_retain (fe_t *fe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fe_t* fe_retain (fe_t* fe);

//	// extern int fe_free (fe_t *fe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_free (fe_t* fe);

//	// extern int fe_process_frames_ext (fe_t *fe, const int16 **inout_spch, size_t *inout_nsamps, mfcc_t **buf_cep, int32 *inout_nframes, int16 *voiced_spch, int32 *voiced_spch_nsamps, int32 *out_frameidx);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_process_frames_ext (fe_t* fe, short** inout_spch, nuint* inout_nsamps, float** buf_cep, int* inout_nframes, short* voiced_spch, int* voiced_spch_nsamps, int* out_frameidx);

//	// extern int fe_process_frames (fe_t *fe, const int16 **inout_spch, size_t *inout_nsamps, mfcc_t **buf_cep, int32 *inout_nframes, int32 *out_frameidx);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_process_frames (fe_t* fe, short** inout_spch, nuint* inout_nsamps, float** buf_cep, int* inout_nframes, int* out_frameidx);

//	// extern int fe_process_utt (fe_t *fe, const int16 *spch, size_t nsamps, mfcc_t ***cep_block, int32 *nframes);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_process_utt (fe_t* fe, short* spch, nuint nsamps, float*** cep_block, int* nframes);

//	// extern void fe_free_2d (void *arr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fe_free_2d (void* arr);

//	// extern int fe_mfcc_to_float (fe_t *fe, mfcc_t **input, float32 **output, int32 nframes);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_mfcc_to_float (fe_t* fe, float** input, float** output, int nframes);

//	// extern int fe_float_to_mfcc (fe_t *fe, float32 **input, mfcc_t **output, int32 nframes);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_float_to_mfcc (fe_t* fe, float** input, float** output, int nframes);

//	// extern int fe_logspec_to_mfcc (fe_t *fe, const mfcc_t *fr_spec, mfcc_t *fr_cep);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_logspec_to_mfcc (fe_t* fe, float* fr_spec, float* fr_cep);

//	// extern int fe_logspec_dct2 (fe_t *fe, const mfcc_t *fr_spec, mfcc_t *fr_cep);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_logspec_dct2 (fe_t* fe, float* fr_spec, float* fr_cep);

//	// extern int fe_mfcc_dct3 (fe_t *fe, const mfcc_t *fr_cep, mfcc_t *fr_spec);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fe_mfcc_dct3 (fe_t* fe, float* fr_cep, float* fr_spec);

//	// extern agc_type_t agc_type_from_str (const char *str);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe agc_type_t agc_type_from_str (sbyte* str);

//	// extern agc_t * agc_init ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe agc_t* agc_init ();

//	// extern void agc_free (agc_t *agc);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void agc_free (agc_t* agc);

//	// extern void agc_max (agc_t *agc, mfcc_t **mfc, int32 n_frame);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void agc_max (agc_t* agc, float** mfc, int n_frame);

//	// extern void agc_emax (agc_t *agc, mfcc_t **mfc, int32 n_frame);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void agc_emax (agc_t* agc, float** mfc, int n_frame);

//	// extern void agc_emax_update (agc_t *agc);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void agc_emax_update (agc_t* agc);

//	// extern float32 agc_emax_get (agc_t *agc);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe float agc_emax_get (agc_t* agc);

//	// extern void agc_emax_set (agc_t *agc, float32 m);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void agc_emax_set (agc_t* agc, float m);

//	// extern void agc_noise (agc_t *agc, mfcc_t **mfc, int32 n_frame);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void agc_noise (agc_t* agc, float** mfc, int n_frame);

//	// extern float32 agc_get_threshold (agc_t *agc);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe float agc_get_threshold (agc_t* agc);

//	// extern void agc_set_threshold (agc_t *agc, float32 threshold);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void agc_set_threshold (agc_t* agc, float threshold);

//	// extern int32 bio_readhdr (FILE *fp, char ***name, char ***val, int32 *swap);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bio_readhdr (FILE* fp, sbyte*** name, sbyte*** val, int* swap);

//	// extern int32 bio_writehdr_version (FILE *fp, char *version);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bio_writehdr_version (FILE* fp, sbyte* version);

//	// extern int32 bio_writehdr (FILE *fp, ...);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bio_writehdr (FILE* fp, IntPtr varArgs);

//	// extern void bio_hdrarg_free (char **name, char **val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void bio_hdrarg_free (sbyte** name, sbyte** val);

//	// extern int32 bio_fread (void *buf, int32 el_sz, int32 n_el, FILE *fp, int32 swap, uint32 *chksum);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bio_fread (void* buf, int el_sz, int n_el, FILE* fp, int swap, uint* chksum);

//	// extern int32 bio_fwrite (const void *buf, int32 el_sz, int32 n_el, FILE *fp, int32 swap, uint32 *chksum);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bio_fwrite (void* buf, int el_sz, int n_el, FILE* fp, int swap, uint* chksum);

//	// extern int32 bio_fread_1d (void **buf, size_t el_sz, uint32 *n_el, FILE *fp, int32 sw, uint32 *ck);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bio_fread_1d (void** buf, nuint el_sz, uint* n_el, FILE* fp, int sw, uint* ck);

//	// extern int32 bio_fread_2d (void ***arr, size_t e_sz, uint32 *d1, uint32 *d2, FILE *fp, uint32 swap, uint32 *chksum);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bio_fread_2d (void*** arr, nuint e_sz, uint* d1, uint* d2, FILE* fp, uint swap, uint* chksum);

//	// extern int32 bio_fread_3d (void ****arr, size_t e_sz, uint32 *d1, uint32 *d2, uint32 *d3, FILE *fp, uint32 swap, uint32 *chksum);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bio_fread_3d (void**** arr, nuint e_sz, uint* d1, uint* d2, uint* d3, FILE* fp, uint swap, uint* chksum);

//	// extern void bio_verify_chksum (FILE *fp, int32 byteswap, uint32 chksum);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void bio_verify_chksum (FILE* fp, int byteswap, uint chksum);

//	// extern int bio_fwrite_1d (void *arr, size_t e_sz, uint32 d1, FILE *fp, uint32 *chksum);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bio_fwrite_1d (void* arr, nuint e_sz, uint d1, FILE* fp, uint* chksum);

//	// extern int bio_fwrite_3d (void ***arr, size_t e_sz, uint32 d1, uint32 d2, uint32 d3, FILE *fp, uint32 *chksum);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bio_fwrite_3d (void*** arr, nuint e_sz, uint d1, uint d2, uint d3, FILE* fp, uint* chksum);

//	// extern int16 * bio_read_wavfile (const char *directory, const char *filename, const char *extension, int32 header, int32 endian, size_t *nsamps);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe short* bio_read_wavfile (sbyte* directory, sbyte* filename, sbyte* extension, int header, int endian, nuint* nsamps);

//	// extern uint64 bitarr_read_int57 (bitarr_address_t address, uint8 length, uint64 mask);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern ulong bitarr_read_int57 (bitarr_address_t address, byte length, ulong mask);

//	// extern void bitarr_write_int57 (bitarr_address_t address, uint8 length, uint64 value);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern void bitarr_write_int57 (bitarr_address_t address, byte length, ulong value);

//	// extern uint32 bitarr_read_int25 (bitarr_address_t address, uint8 length, uint32 mask);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern uint bitarr_read_int25 (bitarr_address_t address, byte length, uint mask);

//	// extern void bitarr_write_int25 (bitarr_address_t address, uint8 length, uint32 value);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern void bitarr_write_int25 (bitarr_address_t address, byte length, uint value);

//	// extern void bitarr_mask_from_max (bitarr_mask_t *bit_mask, uint32 max_value);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void bitarr_mask_from_max (bitarr_mask_t* bit_mask, uint max_value);

//	// extern uint8 bitarr_required_bits (uint32 max_value);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern byte bitarr_required_bits (uint max_value);

//	// extern jmp_buf * ckd_set_jump (jmp_buf *env, int abort);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int[]* ckd_set_jump (int[]* env, int abort);

//	// extern void ckd_fail (char *format, ...);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ckd_fail (sbyte* format, IntPtr varArgs);

//	// extern void * __ckd_calloc__ (size_t n_elem, size_t elem_size, const char *caller_file, int caller_line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* __ckd_calloc__ (nuint n_elem, nuint elem_size, sbyte* caller_file, int caller_line);

//	// extern void * __ckd_malloc__ (size_t size, const char *caller_file, int caller_line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* __ckd_malloc__ (nuint size, sbyte* caller_file, int caller_line);

//	// extern void * __ckd_realloc__ (void *ptr, size_t new_size, const char *caller_file, int caller_line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* __ckd_realloc__ (void* ptr, nuint new_size, sbyte* caller_file, int caller_line);

//	// extern char * __ckd_salloc__ (const char *origstr, const char *caller_file, int caller_line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* __ckd_salloc__ (sbyte* origstr, sbyte* caller_file, int caller_line);

//	// extern void * __ckd_calloc_2d__ (size_t d1, size_t d2, size_t elemsize, const char *caller_file, int caller_line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* __ckd_calloc_2d__ (nuint d1, nuint d2, nuint elemsize, sbyte* caller_file, int caller_line);

//	// extern void * __ckd_calloc_3d__ (size_t d1, size_t d2, size_t d3, size_t elemsize, const char *caller_file, int caller_line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* __ckd_calloc_3d__ (nuint d1, nuint d2, nuint d3, nuint elemsize, sbyte* caller_file, int caller_line);

//	// extern void **** __ckd_calloc_4d__ (size_t d1, size_t d2, size_t d3, size_t d4, size_t elem_size, char *caller_file, int caller_line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void**** __ckd_calloc_4d__ (nuint d1, nuint d2, nuint d3, nuint d4, nuint elem_size, sbyte* caller_file, int caller_line);

//	// extern void * __ckd_alloc_3d_ptr (size_t d1, size_t d2, size_t d3, void *store, size_t elem_size, char *caller_file, int caller_line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* __ckd_alloc_3d_ptr (nuint d1, nuint d2, nuint d3, void* store, nuint elem_size, sbyte* caller_file, int caller_line);

//	// extern void * __ckd_alloc_2d_ptr (size_t d1, size_t d2, void *store, size_t elem_size, char *caller_file, int caller_line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* __ckd_alloc_2d_ptr (nuint d1, nuint d2, void* store, nuint elem_size, sbyte* caller_file, int caller_line);

//	// extern void ckd_free (void *ptr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ckd_free (void* ptr);

//	// extern void ckd_free_2d (void *ptr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ckd_free_2d (void* ptr);

//	// extern void ckd_free_3d (void *ptr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ckd_free_3d (void* ptr);

//	// extern void ckd_free_4d (void *ptr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ckd_free_4d (void* ptr);

//	// extern bitvec_t * bitvec_realloc (bitvec_t *vec, size_t old_len, size_t new_len);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe uint* bitvec_realloc (uint* vec, nuint old_len, nuint new_len);

//	// extern size_t bitvec_count_set (bitvec_t *vec, size_t len);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe nuint bitvec_count_set (uint* vec, nuint len);

//	// extern void ucase (char *str);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ucase (sbyte* str);

//	// extern void lcase (char *str);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void lcase (sbyte* str);

//	// extern int32 strcmp_nocase (const char *str1, const char *str2);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int strcmp_nocase (sbyte* str1, sbyte* str2);

//	// extern int32 strncmp_nocase (const char *str1, const char *str2, size_t len);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int strncmp_nocase (sbyte* str1, sbyte* str2, nuint len);

//	// extern int sgemm_ (char *transa, char *transb, integer *m, integer *n, integer *k, real *alpha, real *a, integer *lda, real *b, integer *ldb, real *beta, real *c__, integer *ldc);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sgemm_ (sbyte* transa, sbyte* transb, int* m, int* n, int* k, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c__, int* ldc);

//	// extern int sgemv_ (char *trans, integer *m, integer *n, real *alpha, real *a, integer *lda, real *x, integer *incx, real *beta, real *y, integer *incy);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sgemv_ (sbyte* trans, int* m, int* n, float* alpha, float* a, int* lda, float* x, int* incx, float* beta, float* y, int* incy);

//	// extern int ssymm_ (char *side, char *uplo, integer *m, integer *n, real *alpha, real *a, integer *lda, real *b, integer *ldb, real *beta, real *c__, integer *ldc);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ssymm_ (sbyte* side, sbyte* uplo, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c__, int* ldc);

//	// extern int sposv_ (char *uplo, integer *n, integer *nrhs, real *a, integer *lda, real *b, integer *ldb, integer *info);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sposv_ (sbyte* uplo, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, int* info);

//	// extern int spotrf_ (char *uplo, integer *n, real *a, integer *lda, integer *info);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int spotrf_ (sbyte* uplo, int* n, float* a, int* lda, int* info);

//	// extern cmn_type_t cmn_type_from_str (const char *str);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe cmn_type_t cmn_type_from_str (sbyte* str);

//	// extern cmn_t * cmn_init (int32 veclen);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe cmn_t* cmn_init (int veclen);

//	// extern void cmn (cmn_t *cmn, mfcc_t **mfc, int32 varnorm, int32 n_frame);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmn (cmn_t* cmn, float** mfc, int varnorm, int n_frame);

//	// extern void cmn_live (cmn_t *cmn, mfcc_t **incep, int32 varnorm, int32 nfr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmn_live (cmn_t* cmn, float** incep, int varnorm, int nfr);

//	// extern void cmn_live_update (cmn_t *cmn);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmn_live_update (cmn_t* cmn);

//	// extern void cmn_live_set (cmn_t *cmn, const mfcc_t *vec);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmn_live_set (cmn_t* cmn, float* vec);

//	// extern void cmn_live_get (cmn_t *cmn, mfcc_t *vec);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmn_live_get (cmn_t* cmn, float* vec);

//	// extern void cmn_free (cmn_t *cmn);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void cmn_free (cmn_t* cmn);

//	// extern void err_msg (err_lvl_t lvl, const char *path, long ln, const char *fmt, ...);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void err_msg (err_lvl_t lvl, sbyte* path, nint ln, sbyte* fmt, IntPtr varArgs);

//	// extern void err_msg_system (err_lvl_t lvl, const char *path, long ln, const char *fmt, ...);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void err_msg_system (err_lvl_t lvl, sbyte* path, nint ln, sbyte* fmt, IntPtr varArgs);

//	// extern void err_logfp_cb (void *user_data, err_lvl_t level, const char *fmt, ...);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void err_logfp_cb (void* user_data, err_lvl_t level, sbyte* fmt, IntPtr varArgs);

//	// extern void err_set_callback (err_cb_f callback, void *user_data);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void err_set_callback (err_cb_f* callback, void* user_data);

//	// extern void err_set_logfp (FILE *stream);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void err_set_logfp (FILE* stream);

//	// extern FILE * err_get_logfp ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe FILE* err_get_logfp ();

//	// extern int err_set_logfile (const char *path);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int err_set_logfile (sbyte* path);

//	// extern int err_set_debug_level (int level);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern int err_set_debug_level (int level);

//	// extern int err_get_debug_level ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern int err_get_debug_level ();

//	// extern int32 ** parse_subvecs (const char *str);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int** parse_subvecs (sbyte* str);

//	// extern void subvecs_free (int32 **subvecs);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void subvecs_free (int** subvecs);

//	// extern mfcc_t *** feat_array_alloc (feat_t *fcb, int32 nfr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe float*** feat_array_alloc (feat_t* fcb, int nfr);

//	// extern mfcc_t *** feat_array_realloc (feat_t *fcb, mfcc_t ***old_feat, int32 ofr, int32 nfr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe float*** feat_array_realloc (feat_t* fcb, float*** old_feat, int ofr, int nfr);

//	// extern void feat_array_free (mfcc_t ***feat);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void feat_array_free (float*** feat);

//	// extern feat_t * feat_init (const char *type, cmn_type_t cmn, int32 varnorm, agc_type_t agc, int32 breport, int32 cepsize);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe feat_t* feat_init (sbyte* type, cmn_type_t cmn, int varnorm, agc_type_t agc, int breport, int cepsize);

//	// extern int32 feat_read_lda (feat_t *feat, const char *ldafile, int32 dim);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int feat_read_lda (feat_t* feat, sbyte* ldafile, int dim);

//	// extern void feat_lda_transform (feat_t *fcb, mfcc_t ***inout_feat, uint32 nfr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void feat_lda_transform (feat_t* fcb, float*** inout_feat, uint nfr);

//	// extern int feat_set_subvecs (feat_t *fcb, int32 **subvecs);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int feat_set_subvecs (feat_t* fcb, int** subvecs);

//	// extern void feat_print (feat_t *fcb, mfcc_t ***feat, int32 nfr, FILE *fp);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void feat_print (feat_t* fcb, float*** feat, int nfr, FILE* fp);

//	// extern int32 feat_s2mfc2feat (feat_t *fcb, const char *file, const char *dir, const char *cepext, int32 sf, int32 ef, mfcc_t ***feat, int32 maxfr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int feat_s2mfc2feat (feat_t* fcb, sbyte* file, sbyte* dir, sbyte* cepext, int sf, int ef, float*** feat, int maxfr);

//	// extern int32 feat_s2mfc2feat_live (feat_t *fcb, mfcc_t **uttcep, int32 *inout_ncep, int32 beginutt, int32 endutt, mfcc_t ***ofeat);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int feat_s2mfc2feat_live (feat_t* fcb, float** uttcep, int* inout_ncep, int beginutt, int endutt, float*** ofeat);

//	// extern void feat_update_stats (feat_t *fcb);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void feat_update_stats (feat_t* fcb);

//	// extern feat_t * feat_retain (feat_t *f);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe feat_t* feat_retain (feat_t* f);

//	// extern int feat_free (feat_t *f);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int feat_free (feat_t* f);

//	// extern void feat_report (feat_t *f);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void feat_report (feat_t* f);

//	// extern const char * path2basename (const char *path);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* path2basename (sbyte* path);

//	// extern void path2dirname (const char *path, char *dir);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void path2dirname (sbyte* path, sbyte* dir);

//	// extern void strip_fileext (const char *file, char *root);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void strip_fileext (sbyte* file, sbyte* root);

//	// extern int path_is_absolute (const char *file);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int path_is_absolute (sbyte* file);

//	// extern glist_t glist_add_ptr (glist_t g, void *ptr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe glist_t* glist_add_ptr (glist_t* g, void* ptr);

//	// extern glist_t glist_add_int32 (glist_t g, int32 val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe glist_t* glist_add_int32 (glist_t* g, int val);

//	// extern glist_t glist_add_uint32 (glist_t g, uint32 val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe glist_t* glist_add_uint32 (glist_t* g, uint val);

//	// extern glist_t glist_add_float32 (glist_t g, float32 val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe glist_t* glist_add_float32 (glist_t* g, float val);

//	// extern glist_t glist_add_float64 (glist_t g, float64 val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe glist_t* glist_add_float64 (glist_t* g, double val);

//	// extern gnode_t * glist_insert_ptr (gnode_t *gn, void *ptr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe gnode_t* glist_insert_ptr (gnode_t* gn, void* ptr);

//	// extern gnode_t * glist_insert_int32 (gnode_t *gn, int32 val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe gnode_t* glist_insert_int32 (gnode_t* gn, int val);

//	// extern gnode_t * glist_insert_uint32 (gnode_t *gn, uint32 val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe gnode_t* glist_insert_uint32 (gnode_t* gn, uint val);

//	// extern gnode_t * glist_insert_float32 (gnode_t *gn, float32 val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe gnode_t* glist_insert_float32 (gnode_t* gn, float val);

//	// extern gnode_t * glist_insert_float64 (gnode_t *gn, float64 val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe gnode_t* glist_insert_float64 (gnode_t* gn, double val);

//	// extern glist_t glist_reverse (glist_t g);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe glist_t* glist_reverse (glist_t* g);

//	// extern int32 glist_count (glist_t g);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int glist_count (glist_t* g);

//	// extern void glist_free (glist_t g);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void glist_free (glist_t* g);

//	// extern gnode_t * gnode_free (gnode_t *gn, gnode_t *pred);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe gnode_t* gnode_free (gnode_t* gn, gnode_t* pred);

//	// extern gnode_t * glist_tail (glist_t g);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe gnode_t* glist_tail (glist_t* g);

//	// extern logmath_t * logmath_init (float64 base, int shift, int use_table);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe logmath_t* logmath_init (double @base, int shift, int use_table);

//	// extern logmath_t * logmath_read (const char *filename);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe logmath_t* logmath_read (sbyte* filename);

//	// extern int32 logmath_write (logmath_t *lmath, const char *filename);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_write (logmath_t* lmath, sbyte* filename);

//	// extern int32 logmath_get_table_shape (logmath_t *lmath, uint32 *out_size, uint32 *out_width, uint32 *out_shift);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_get_table_shape (logmath_t* lmath, uint* out_size, uint* out_width, uint* out_shift);

//	// extern float64 logmath_get_base (logmath_t *lmath);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe double logmath_get_base (logmath_t* lmath);

//	// extern int logmath_get_zero (logmath_t *lmath);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_get_zero (logmath_t* lmath);

//	// extern int logmath_get_width (logmath_t *lmath);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_get_width (logmath_t* lmath);

//	// extern int logmath_get_shift (logmath_t *lmath);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_get_shift (logmath_t* lmath);

//	// extern logmath_t * logmath_retain (logmath_t *lmath);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe logmath_t* logmath_retain (logmath_t* lmath);

//	// extern int logmath_free (logmath_t *lmath);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_free (logmath_t* lmath);

//	// extern int logmath_add_exact (logmath_t *lmath, int logb_p, int logb_q);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_add_exact (logmath_t* lmath, int logb_p, int logb_q);

//	// extern int logmath_add (logmath_t *lmath, int logb_p, int logb_q);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_add (logmath_t* lmath, int logb_p, int logb_q);

//	// extern int logmath_log (logmath_t *lmath, float64 p);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_log (logmath_t* lmath, double p);

//	// extern float64 logmath_exp (logmath_t *lmath, int logb_p);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe double logmath_exp (logmath_t* lmath, int logb_p);

//	// extern int logmath_ln_to_log (logmath_t *lmath, float64 log_p);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_ln_to_log (logmath_t* lmath, double log_p);

//	// extern float64 logmath_log_to_ln (logmath_t *lmath, int logb_p);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe double logmath_log_to_ln (logmath_t* lmath, int logb_p);

//	// extern int logmath_log10_to_log (logmath_t *lmath, float64 log_p);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int logmath_log10_to_log (logmath_t* lmath, double log_p);

//	// extern float logmath_log10_to_log_float (logmath_t *lmath, float64 log_p);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe float logmath_log10_to_log_float (logmath_t* lmath, double log_p);

//	// extern float64 logmath_log_to_log10 (logmath_t *lmath, int logb_p);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe double logmath_log_to_log10 (logmath_t* lmath, int logb_p);

//	// extern float64 logmath_log_float_to_log10 (logmath_t *lmath, float log_p);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe double logmath_log_float_to_log10 (logmath_t* lmath, float log_p);

//	// extern hash_table_t * hash_table_new (int32 size, int32 casearg);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe hash_table_t* hash_table_new (int size, int casearg);

//	// extern void hash_table_free (hash_table_t *h);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void hash_table_free (hash_table_t* h);

//	// extern void * hash_table_enter (hash_table_t *h, const char *key, void *val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* hash_table_enter (hash_table_t* h, sbyte* key, void* val);

//	// extern void * hash_table_replace (hash_table_t *h, const char *key, void *val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* hash_table_replace (hash_table_t* h, sbyte* key, void* val);

//	// extern void * hash_table_delete (hash_table_t *h, const char *key);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* hash_table_delete (hash_table_t* h, sbyte* key);

//	// extern void * hash_table_delete_bkey (hash_table_t *h, const char *key, size_t len);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* hash_table_delete_bkey (hash_table_t* h, sbyte* key, nuint len);

//	// extern void hash_table_empty (hash_table_t *h);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void hash_table_empty (hash_table_t* h);

//	// extern void * hash_table_enter_bkey (hash_table_t *h, const char *key, size_t len, void *val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* hash_table_enter_bkey (hash_table_t* h, sbyte* key, nuint len, void* val);

//	// extern void * hash_table_replace_bkey (hash_table_t *h, const char *key, size_t len, void *val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* hash_table_replace_bkey (hash_table_t* h, sbyte* key, nuint len, void* val);

//	// extern int32 hash_table_lookup (hash_table_t *h, const char *key, void **val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int hash_table_lookup (hash_table_t* h, sbyte* key, void** val);

//	// extern int32 hash_table_lookup_int32 (hash_table_t *h, const char *key, int32 *val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int hash_table_lookup_int32 (hash_table_t* h, sbyte* key, int* val);

//	// extern int32 hash_table_lookup_bkey (hash_table_t *h, const char *key, size_t len, void **val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int hash_table_lookup_bkey (hash_table_t* h, sbyte* key, nuint len, void** val);

//	// extern int32 hash_table_lookup_bkey_int32 (hash_table_t *h, const char *key, size_t len, int32 *val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int hash_table_lookup_bkey_int32 (hash_table_t* h, sbyte* key, nuint len, int* val);

//	// extern hash_iter_t * hash_table_iter (hash_table_t *h);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe hash_iter_t* hash_table_iter (hash_table_t* h);

//	// extern hash_iter_t * hash_table_iter_next (hash_iter_t *itor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe hash_iter_t* hash_table_iter_next (hash_iter_t* itor);

//	// extern void hash_table_iter_free (hash_iter_t *itor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void hash_table_iter_free (hash_iter_t* itor);

//	// extern glist_t hash_table_tolist (hash_table_t *h, int32 *count);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe glist_t* hash_table_tolist (hash_table_t* h, int* count);

//	// extern void hash_table_display (hash_table_t *h, int32 showkey);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void hash_table_display (hash_table_t* h, int showkey);

//	// extern listelem_alloc_t * listelem_alloc_init (size_t elemsize);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe listelem_alloc_t* listelem_alloc_init (nuint elemsize);

//	// extern void listelem_alloc_free (listelem_alloc_t *le);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void listelem_alloc_free (listelem_alloc_t* le);

//	// extern void * __listelem_malloc__ (listelem_alloc_t *le, char *file, int line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* __listelem_malloc__ (listelem_alloc_t* le, sbyte* file, int line);

//	// extern void * __listelem_malloc_id__ (listelem_alloc_t *le, char *file, int line, int32 *out_id);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* __listelem_malloc_id__ (listelem_alloc_t* le, sbyte* file, int line, int* out_id);

//	// extern void * listelem_get_item (listelem_alloc_t *le, int32 id);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* listelem_get_item (listelem_alloc_t* le, int id);

//	// extern void __listelem_free__ (listelem_alloc_t *le, void *elem, char *file, int line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void __listelem_free__ (listelem_alloc_t* le, void* elem, sbyte* file, int line);

//	// extern void listelem_stats (listelem_alloc_t *le);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void listelem_stats (listelem_alloc_t* le);

//	// extern fsg_model_t * fsg_model_init (const char *name, logmath_t *lmath, float32 lw, int32 n_state);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_model_t* fsg_model_init (sbyte* name, logmath_t* lmath, float lw, int n_state);

//	// extern fsg_model_t * fsg_model_readfile (const char *file, logmath_t *lmath, float32 lw);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_model_t* fsg_model_readfile (sbyte* file, logmath_t* lmath, float lw);

//	// extern fsg_model_t * fsg_model_read (FILE *fp, logmath_t *lmath, float32 lw);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_model_t* fsg_model_read (FILE* fp, logmath_t* lmath, float lw);

//	// extern fsg_model_t * fsg_model_retain (fsg_model_t *fsg);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_model_t* fsg_model_retain (fsg_model_t* fsg);

//	// extern int fsg_model_free (fsg_model_t *fsg);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fsg_model_free (fsg_model_t* fsg);

//	// extern int fsg_model_word_add (fsg_model_t *fsg, const char *word);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fsg_model_word_add (fsg_model_t* fsg, sbyte* word);

//	// extern int fsg_model_word_id (fsg_model_t *fsg, const char *word);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fsg_model_word_id (fsg_model_t* fsg, sbyte* word);

//	// extern void fsg_model_trans_add (fsg_model_t *fsg, int32 from, int32 to, int32 logp, int32 wid);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fsg_model_trans_add (fsg_model_t* fsg, int from, int to, int logp, int wid);

//	// extern int32 fsg_model_null_trans_add (fsg_model_t *fsg, int32 from, int32 to, int32 logp);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fsg_model_null_trans_add (fsg_model_t* fsg, int from, int to, int logp);

//	// extern int32 fsg_model_tag_trans_add (fsg_model_t *fsg, int32 from, int32 to, int32 logp, int32 wid);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fsg_model_tag_trans_add (fsg_model_t* fsg, int from, int to, int logp, int wid);

//	// extern glist_t fsg_model_null_trans_closure (fsg_model_t *fsg, glist_t nulls);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe glist_t* fsg_model_null_trans_closure (fsg_model_t* fsg, glist_t* nulls);

//	// extern glist_t fsg_model_trans (fsg_model_t *fsg, int32 i, int32 j);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe glist_t* fsg_model_trans (fsg_model_t* fsg, int i, int j);

//	// extern fsg_arciter_t * fsg_model_arcs (fsg_model_t *fsg, int32 i);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_arciter_t* fsg_model_arcs (fsg_model_t* fsg, int i);

//	// extern fsg_link_t * fsg_arciter_get (fsg_arciter_t *itor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_link_t* fsg_arciter_get (fsg_arciter_t* itor);

//	// extern fsg_arciter_t * fsg_arciter_next (fsg_arciter_t *itor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_arciter_t* fsg_arciter_next (fsg_arciter_t* itor);

//	// extern void fsg_arciter_free (fsg_arciter_t *itor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fsg_arciter_free (fsg_arciter_t* itor);

//	// extern fsg_link_t * fsg_model_null_trans (fsg_model_t *fsg, int32 i, int32 j);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_link_t* fsg_model_null_trans (fsg_model_t* fsg, int i, int j);

//	// extern int fsg_model_add_silence (fsg_model_t *fsg, const char *silword, int state, float32 silprob);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fsg_model_add_silence (fsg_model_t* fsg, sbyte* silword, int state, float silprob);

//	// extern int fsg_model_add_alt (fsg_model_t *fsg, const char *baseword, const char *altword);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fsg_model_add_alt (fsg_model_t* fsg, sbyte* baseword, sbyte* altword);

//	// extern void fsg_model_write (fsg_model_t *fsg, FILE *fp);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fsg_model_write (fsg_model_t* fsg, FILE* fp);

//	// extern void fsg_model_writefile (fsg_model_t *fsg, const char *file);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fsg_model_writefile (fsg_model_t* fsg, sbyte* file);

//	// extern void fsg_model_write_fsm (fsg_model_t *fsg, FILE *fp);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fsg_model_write_fsm (fsg_model_t* fsg, FILE* fp);

//	// extern void fsg_model_writefile_fsm (fsg_model_t *fsg, const char *file);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fsg_model_writefile_fsm (fsg_model_t* fsg, sbyte* file);

//	// extern void fsg_model_write_symtab (fsg_model_t *fsg, FILE *file);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fsg_model_write_symtab (fsg_model_t* fsg, FILE* file);

//	// extern void fsg_model_writefile_symtab (fsg_model_t *fsg, const char *file);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fsg_model_writefile_symtab (fsg_model_t* fsg, sbyte* file);

//	// extern void genrand_seed (unsigned long s);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern void genrand_seed (nuint s);

//	// extern long genrand_int31 ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern nint genrand_int31 ();

//	// extern double genrand_real3 ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern double genrand_real3 ();

//	// extern double genrand_res53 ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern double genrand_res53 ();

//	// extern heap_t * heap_new ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe heap_t* heap_new ();

//	// extern int heap_insert (heap_t *heap, void *data, int32 val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int heap_insert (heap_t* heap, void* data, int val);

//	// extern int heap_top (heap_t *heap, void **data, int32 *val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int heap_top (heap_t* heap, void** data, int* val);

//	// extern int heap_pop (heap_t *heap, void **data, int32 *val);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int heap_pop (heap_t* heap, void** data, int* val);

//	// extern int heap_remove (heap_t *heap, void *data);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int heap_remove (heap_t* heap, void* data);

//	// extern size_t heap_size (heap_t *heap);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe nuint heap_size (heap_t* heap);

//	// extern int heap_destroy (heap_t *heap);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int heap_destroy (heap_t* heap);

//	// extern jsgf_t * jsgf_grammar_new (jsgf_t *parent);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe jsgf_t* jsgf_grammar_new (jsgf_t* parent);

//	// extern jsgf_t * jsgf_parse_file (const char *filename, jsgf_t *parent);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe jsgf_t* jsgf_parse_file (sbyte* filename, jsgf_t* parent);

//	// extern jsgf_t * jsgf_parse_string (const char *string, jsgf_t *parent);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe jsgf_t* jsgf_parse_string (sbyte* @string, jsgf_t* parent);

//	// extern const char * jsgf_grammar_name (jsgf_t *jsgf);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* jsgf_grammar_name (jsgf_t* jsgf);

//	// extern void jsgf_grammar_free (jsgf_t *jsgf);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void jsgf_grammar_free (jsgf_t* jsgf);

//	// extern jsgf_rule_iter_t * jsgf_rule_iter (jsgf_t *grammar);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe jsgf_rule_iter_t* jsgf_rule_iter (jsgf_t* grammar);

//	// extern jsgf_rule_t * jsgf_get_rule (jsgf_t *grammar, const char *name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe jsgf_rule_t* jsgf_get_rule (jsgf_t* grammar, sbyte* name);

//	// extern jsgf_rule_t * jsgf_get_public_rule (jsgf_t *grammar);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe jsgf_rule_t* jsgf_get_public_rule (jsgf_t* grammar);

//	// extern const char * jsgf_rule_name (jsgf_rule_t *rule);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* jsgf_rule_name (jsgf_rule_t* rule);

//	// extern int jsgf_rule_public (jsgf_rule_t *rule);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int jsgf_rule_public (jsgf_rule_t* rule);

//	// extern fsg_model_t * jsgf_build_fsg (jsgf_t *grammar, jsgf_rule_t *rule, logmath_t *lmath, float32 lw);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_model_t* jsgf_build_fsg (jsgf_t* grammar, jsgf_rule_t* rule, logmath_t* lmath, float lw);

//	// extern fsg_model_t * jsgf_build_fsg_raw (jsgf_t *grammar, jsgf_rule_t *rule, logmath_t *lmath, float32 lw);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_model_t* jsgf_build_fsg_raw (jsgf_t* grammar, jsgf_rule_t* rule, logmath_t* lmath, float lw);

//	// extern fsg_model_t * jsgf_read_file (const char *file, logmath_t *lmath, float32 lw);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_model_t* jsgf_read_file (sbyte* file, logmath_t* lmath, float lw);

//	// extern fsg_model_t * jsgf_read_string (const char *string, logmath_t *lmath, float32 lw);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe fsg_model_t* jsgf_read_string (sbyte* @string, logmath_t* lmath, float lw);

//	// extern int jsgf_write_fsg (jsgf_t *grammar, jsgf_rule_t *rule, FILE *outfh);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int jsgf_write_fsg (jsgf_t* grammar, jsgf_rule_t* rule, FILE* outfh);

//	// extern void norm_3d (float32 ***arr, uint32 d1, uint32 d2, uint32 d3);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void norm_3d (float*** arr, uint d1, uint d2, uint d3);

//	// extern void accum_3d (float32 ***out, float32 ***in, uint32 d1, uint32 d2, uint32 d3);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void accum_3d (float*** @out, float*** @in, uint d1, uint d2, uint d3);

//	// extern void band_nz_1d (float32 *v, uint32 d1, float32 band);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void band_nz_1d (float* v, uint d1, float band);

//	// extern void floor_nz_3d (float32 ***m, uint32 d1, uint32 d2, uint32 d3, float32 floor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void floor_nz_3d (float*** m, uint d1, uint d2, uint d3, float floor);

//	// extern void floor_nz_1d (float32 *v, uint32 d1, float32 floor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void floor_nz_1d (float* v, uint d1, float floor);

//	// extern float64 determinant (float32 **a, int32 len);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe double determinant (float** a, int len);

//	// extern int32 invert (float32 **out_ainv, float32 **a, int32 len);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int invert (float** out_ainv, float** a, int len);

//	// extern int32 solve (float32 **a, float32 *b, float32 *out_x, int32 n);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int solve (float** a, float* b, float* out_x, int n);

//	// extern void outerproduct (float32 **out_a, float32 *x, float32 *y, int32 len);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void outerproduct (float** out_a, float* x, float* y, int len);

//	// extern void matrixmultiply (float32 **out_c, float32 **a, float32 **b, int32 n);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void matrixmultiply (float** out_c, float** a, float** b, int n);

//	// extern void scalarmultiply (float32 **inout_a, float32 x, int32 n);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void scalarmultiply (float** inout_a, float x, int n);

//	// extern void matrixadd (float32 **inout_a, float32 **b, int32 n);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void matrixadd (float** inout_a, float** b, int n);

//	// extern mmio_file_t * mmio_file_read (const char *filename);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe mmio_file_t* mmio_file_read (sbyte* filename);

//	// extern void * mmio_file_ptr (mmio_file_t *mf);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* mmio_file_ptr (mmio_file_t* mf);

//	// extern void mmio_file_unmap (mmio_file_t *mf);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void mmio_file_unmap (mmio_file_t* mf);

//	// extern ngram_model_t * ngram_model_read (cmd_ln_t *config, const char *file_name, ngram_file_type_t file_type, logmath_t *lmath);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_t* ngram_model_read (cmd_ln_t* config, sbyte* file_name, ngram_file_type_t file_type, logmath_t* lmath);

//	// extern int ngram_model_write (ngram_model_t *model, const char *file_name, ngram_file_type_t format);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_write (ngram_model_t* model, sbyte* file_name, ngram_file_type_t format);

//	// extern ngram_file_type_t ngram_file_name_to_type (const char *file_name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_file_type_t ngram_file_name_to_type (sbyte* file_name);

//	// extern ngram_file_type_t ngram_str_to_type (const char *str_name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_file_type_t ngram_str_to_type (sbyte* str_name);

//	// extern const char * ngram_type_to_str (int type);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* ngram_type_to_str (int type);

//	// extern ngram_model_t * ngram_model_retain (ngram_model_t *model);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_t* ngram_model_retain (ngram_model_t* model);

//	// extern int ngram_model_free (ngram_model_t *model);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_free (ngram_model_t* model);

//	// extern int ngram_model_casefold (ngram_model_t *model, int kase);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_casefold (ngram_model_t* model, int kase);

//	// extern int ngram_model_apply_weights (ngram_model_t *model, float32 lw, float32 wip);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_apply_weights (ngram_model_t* model, float lw, float wip);

//	// extern float32 ngram_model_get_weights (ngram_model_t *model, int32 *out_log_wip);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe float ngram_model_get_weights (ngram_model_t* model, int* out_log_wip);

//	// extern int32 ngram_score (ngram_model_t *model, const char *word, ...);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_score (ngram_model_t* model, sbyte* word, IntPtr varArgs);

//	// extern int32 ngram_tg_score (ngram_model_t *model, int32 w3, int32 w2, int32 w1, int32 *n_used);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_tg_score (ngram_model_t* model, int w3, int w2, int w1, int* n_used);

//	// extern int32 ngram_bg_score (ngram_model_t *model, int32 w2, int32 w1, int32 *n_used);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_bg_score (ngram_model_t* model, int w2, int w1, int* n_used);

//	// extern int32 ngram_ng_score (ngram_model_t *model, int32 wid, int32 *history, int32 n_hist, int32 *n_used);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_ng_score (ngram_model_t* model, int wid, int* history, int n_hist, int* n_used);

//	// extern int32 ngram_probv (ngram_model_t *model, const char *word, ...);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_probv (ngram_model_t* model, sbyte* word, IntPtr varArgs);

//	// extern int32 ngram_prob (ngram_model_t *model, const char *const *words, int32 n);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_prob (ngram_model_t* model, sbyte** words, int n);

//	// extern int32 ngram_ng_prob (ngram_model_t *model, int32 wid, int32 *history, int32 n_hist, int32 *n_used);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_ng_prob (ngram_model_t* model, int wid, int* history, int n_hist, int* n_used);

//	// extern int32 ngram_score_to_prob (ngram_model_t *model, int32 score);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_score_to_prob (ngram_model_t* model, int score);

//	// extern int32 ngram_wid (ngram_model_t *model, const char *word);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_wid (ngram_model_t* model, sbyte* word);

//	// extern const char * ngram_word (ngram_model_t *model, int32 wid);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* ngram_word (ngram_model_t* model, int wid);

//	// extern int32 ngram_unknown_wid (ngram_model_t *model);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_unknown_wid (ngram_model_t* model);

//	// extern int32 ngram_zero (ngram_model_t *model);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_zero (ngram_model_t* model);

//	// extern int32 ngram_model_get_size (ngram_model_t *model);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_get_size (ngram_model_t* model);

//	// extern const uint32 * ngram_model_get_counts (ngram_model_t *model);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe uint* ngram_model_get_counts (ngram_model_t* model);

//	// extern ngram_iter_t * ngram_model_mgrams (ngram_model_t *model, int m);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_iter_t* ngram_model_mgrams (ngram_model_t* model, int m);

//	// extern ngram_iter_t * ngram_iter (ngram_model_t *model, const char *word, ...);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_iter_t* ngram_iter (ngram_model_t* model, sbyte* word, IntPtr varArgs);

//	// extern ngram_iter_t * ngram_ng_iter (ngram_model_t *model, int32 wid, int32 *history, int32 n_hist);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_iter_t* ngram_ng_iter (ngram_model_t* model, int wid, int* history, int n_hist);

//	// extern const int32 * ngram_iter_get (ngram_iter_t *itor, int32 *out_score, int32 *out_bowt);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int* ngram_iter_get (ngram_iter_t* itor, int* out_score, int* out_bowt);

//	// extern ngram_iter_t * ngram_iter_successors (ngram_iter_t *itor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_iter_t* ngram_iter_successors (ngram_iter_t* itor);

//	// extern ngram_iter_t * ngram_iter_next (ngram_iter_t *itor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_iter_t* ngram_iter_next (ngram_iter_t* itor);

//	// extern void ngram_iter_free (ngram_iter_t *itor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ngram_iter_free (ngram_iter_t* itor);

//	// extern int32 ngram_model_add_word (ngram_model_t *model, const char *word, float32 weight);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_add_word (ngram_model_t* model, sbyte* word, float weight);

//	// extern int32 ngram_model_read_classdef (ngram_model_t *model, const char *file_name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_read_classdef (ngram_model_t* model, sbyte* file_name);

//	// extern int32 ngram_model_add_class (ngram_model_t *model, const char *classname, float32 classweight, char **words, const float32 *weights, int32 n_words);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_add_class (ngram_model_t* model, sbyte* classname, float classweight, sbyte** words, float* weights, int n_words);

//	// extern int32 ngram_model_add_class_word (ngram_model_t *model, const char *classname, const char *word, float32 weight);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_add_class_word (ngram_model_t* model, sbyte* classname, sbyte* word, float weight);

//	// extern ngram_model_t * ngram_model_set_init (cmd_ln_t *config, ngram_model_t **models, char **names, const float32 *weights, int32 n_models);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_t* ngram_model_set_init (cmd_ln_t* config, ngram_model_t** models, sbyte** names, float* weights, int n_models);

//	// extern ngram_model_t * ngram_model_set_read (cmd_ln_t *config, const char *lmctlfile, logmath_t *lmath);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_t* ngram_model_set_read (cmd_ln_t* config, sbyte* lmctlfile, logmath_t* lmath);

//	// extern int32 ngram_model_set_count (ngram_model_t *set);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_set_count (ngram_model_t* set);

//	// extern ngram_model_set_iter_t * ngram_model_set_iter (ngram_model_t *set);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_set_iter_t* ngram_model_set_iter (ngram_model_t* set);

//	// extern ngram_model_set_iter_t * ngram_model_set_iter_next (ngram_model_set_iter_t *itor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_set_iter_t* ngram_model_set_iter_next (ngram_model_set_iter_t* itor);

//	// extern void ngram_model_set_iter_free (ngram_model_set_iter_t *itor);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ngram_model_set_iter_free (ngram_model_set_iter_t* itor);

//	// extern ngram_model_t * ngram_model_set_iter_model (ngram_model_set_iter_t *itor, const char **lmname);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_t* ngram_model_set_iter_model (ngram_model_set_iter_t* itor, sbyte** lmname);

//	// extern ngram_model_t * ngram_model_set_select (ngram_model_t *set, const char *name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_t* ngram_model_set_select (ngram_model_t* set, sbyte* name);

//	// extern ngram_model_t * ngram_model_set_lookup (ngram_model_t *set, const char *name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_t* ngram_model_set_lookup (ngram_model_t* set, sbyte* name);

//	// extern const char * ngram_model_set_current (ngram_model_t *set);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* ngram_model_set_current (ngram_model_t* set);

//	// extern ngram_model_t * ngram_model_set_interp (ngram_model_t *set, const char **names, const float32 *weights);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_t* ngram_model_set_interp (ngram_model_t* set, sbyte** names, float* weights);

//	// extern ngram_model_t * ngram_model_set_add (ngram_model_t *set, ngram_model_t *model, const char *name, float32 weight, int reuse_widmap);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_t* ngram_model_set_add (ngram_model_t* set, ngram_model_t* model, sbyte* name, float weight, int reuse_widmap);

//	// extern ngram_model_t * ngram_model_set_remove (ngram_model_t *set, const char *name, int reuse_widmap);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe ngram_model_t* ngram_model_set_remove (ngram_model_t* set, sbyte* name, int reuse_widmap);

//	// extern void ngram_model_set_map_words (ngram_model_t *set, const char **words, int32 n_words);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ngram_model_set_map_words (ngram_model_t* set, sbyte** words, int n_words);

//	// extern int32 ngram_model_set_current_wid (ngram_model_t *set, int32 set_wid);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_set_current_wid (ngram_model_t* set, int set_wid);

//	// extern int32 ngram_model_set_known_wid (ngram_model_t *set, int32 set_wid);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int ngram_model_set_known_wid (ngram_model_t* set, int set_wid);

//	// extern void ngram_model_flush (ngram_model_t *lm);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ngram_model_flush (ngram_model_t* lm);

//	// extern FILE * fopen_comp (const char *file, const char *mode, int32 *ispipe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe FILE* fopen_comp (sbyte* file, sbyte* mode, int* ispipe);

//	// extern void fclose_comp (FILE *fp, int32 ispipe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void fclose_comp (FILE* fp, int ispipe);

//	// extern FILE * fopen_compchk (const char *file, int32 *ispipe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe FILE* fopen_compchk (sbyte* file, int* ispipe);

//	// extern FILE * _myfopen (const char *file, const char *mode, const char *pgm, int32 line);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe FILE* _myfopen (sbyte* file, sbyte* mode, sbyte* pgm, int line);

//	// extern int32 fread_retry (void *pointer, int32 size, int32 num_items, FILE *stream);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int fread_retry (void* pointer, int size, int num_items, FILE* stream);

//	// extern char * fread_line (FILE *stream, size_t *out_len);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* fread_line (FILE* stream, nuint* out_len);

//	// extern lineiter_t * lineiter_start (FILE *fh);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe lineiter_t* lineiter_start (FILE* fh);

//	// extern lineiter_t * lineiter_start_clean (FILE *fh);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe lineiter_t* lineiter_start_clean (FILE* fh);

//	// extern lineiter_t * lineiter_next (lineiter_t *li);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe lineiter_t* lineiter_next (lineiter_t* li);

//	// extern void lineiter_free (lineiter_t *li);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void lineiter_free (lineiter_t* li);

//	// extern int lineiter_lineno (lineiter_t *li);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int lineiter_lineno (lineiter_t* li);

//	// extern bit_encode_t * bit_encode_attach (FILE *outfh);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe bit_encode_t* bit_encode_attach (FILE* outfh);

//	// extern bit_encode_t * bit_encode_retain (bit_encode_t *be);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe bit_encode_t* bit_encode_retain (bit_encode_t* be);

//	// extern int bit_encode_free (bit_encode_t *be);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bit_encode_free (bit_encode_t* be);

//	// extern int bit_encode_write (bit_encode_t *be, const unsigned char *bits, int nbits);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bit_encode_write (bit_encode_t* be, byte* bits, int nbits);

//	// extern int bit_encode_write_cw (bit_encode_t *be, uint32 codeword, int nbits);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bit_encode_write_cw (bit_encode_t* be, uint codeword, int nbits);

//	// extern int bit_encode_flush (bit_encode_t *be);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int bit_encode_flush (bit_encode_t* be);

//	// extern int32 stat_retry (const char *file, struct stat *statbuf);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int stat_retry (sbyte* file, stat* statbuf);

//	// extern int32 stat_mtime (const char *file);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int stat_mtime (sbyte* file);

//	// extern int build_directory (const char *path);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int build_directory (sbyte* path);

//	// extern priority_queue_t * priority_queue_create (size_t len, int (* compare)(const void *, const void *));
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe priority_queue_t* priority_queue_create (nuint len, Func<void*, void*, int>* compare);

//	// extern void * priority_queue_poll (priority_queue_t *queue);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* priority_queue_poll (priority_queue_t* queue);

//	// extern void priority_queue_add (priority_queue_t *queue, void *element);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void priority_queue_add (priority_queue_t* queue, void* element);

//	// extern size_t priority_queue_size (priority_queue_t *queue);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe nuint priority_queue_size (priority_queue_t* queue);

//	// extern void priority_queue_free (priority_queue_t *queue, void (* free_ptr)(void *));
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void priority_queue_free (priority_queue_t* queue, Action<void*>* free_ptr);

//	// extern pctr_t * pctr_new (char *name);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe pctr_t* pctr_new (sbyte* name);

//	// extern void pctr_reset (pctr_t *ctr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void pctr_reset (pctr_t* ctr);

//	// extern void pctr_print (FILE *fp, pctr_t *ctr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void pctr_print (FILE* fp, pctr_t* ctr);

//	// extern void pctr_increment (pctr_t *ctr, int32 inc);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void pctr_increment (pctr_t* ctr, int inc);

//	// extern void pctr_free (pctr_t *ctr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void pctr_free (pctr_t* ctr);

//	// extern void ptmr_start (ptmr_t *tmr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ptmr_start (ptmr_t* tmr);

//	// extern void ptmr_stop (ptmr_t *tmr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ptmr_stop (ptmr_t* tmr);

//	// extern void ptmr_reset (ptmr_t *tmr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ptmr_reset (ptmr_t* tmr);

//	// extern void ptmr_init (ptmr_t *tmr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ptmr_init (ptmr_t* tmr);

//	// extern void ptmr_reset_all (ptmr_t *tmr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ptmr_reset_all (ptmr_t* tmr);

//	// extern void ptmr_print_all (FILE *fp, ptmr_t *tmr, float64 norm);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void ptmr_print_all (FILE* fp, ptmr_t* tmr, double norm);

//	// extern int32 host_pclk (int32 dummy);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern int host_pclk (int dummy);

//	// extern int32 host_endian ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern int host_endian ();

//	// extern sbthread_t * sbthread_start (cmd_ln_t *config, sbthread_main func, void *arg);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbthread_t* sbthread_start (cmd_ln_t* config, sbthread_main* func, void* arg);

//	// extern int sbthread_wait (sbthread_t *th);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sbthread_wait (sbthread_t* th);

//	// extern void sbthread_free (sbthread_t *th);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void sbthread_free (sbthread_t* th);

//	// extern cmd_ln_t * sbthread_config (sbthread_t *th);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe cmd_ln_t* sbthread_config (sbthread_t* th);

//	// extern void * sbthread_arg (sbthread_t *th);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* sbthread_arg (sbthread_t* th);

//	// extern sbmsgq_t * sbthread_msgq (sbthread_t *th);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbmsgq_t* sbthread_msgq (sbthread_t* th);

//	// extern int sbthread_wait (sbthread_t *th);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sbthread_wait (sbthread_t* th);

//	// extern int sbthread_send (sbthread_t *th, size_t len, const void *data);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sbthread_send (sbthread_t* th, nuint len, void* data);

//	// extern sbmsgq_t * sbmsgq_init (size_t depth);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbmsgq_t* sbmsgq_init (nuint depth);

//	// extern void sbmsgq_free (sbmsgq_t *q);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void sbmsgq_free (sbmsgq_t* q);

//	// extern int sbmsgq_send (sbmsgq_t *q, size_t len, const void *data);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sbmsgq_send (sbmsgq_t* q, nuint len, void* data);

//	// extern void * sbmsgq_wait (sbmsgq_t *q, size_t *out_len, int sec, int nsec);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void* sbmsgq_wait (sbmsgq_t* q, nuint* out_len, int sec, int nsec);

//	// extern sbmtx_t * sbmtx_init ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbmtx_t* sbmtx_init ();

//	// extern int sbmtx_trylock (sbmtx_t *mtx);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sbmtx_trylock (sbmtx_t* mtx);

//	// extern int sbmtx_lock (sbmtx_t *mtx);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sbmtx_lock (sbmtx_t* mtx);

//	// extern int sbmtx_unlock (sbmtx_t *mtx);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sbmtx_unlock (sbmtx_t* mtx);

//	// extern void sbmtx_free (sbmtx_t *mtx);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void sbmtx_free (sbmtx_t* mtx);

//	// extern sbevent_t * sbevent_init ();
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbevent_t* sbevent_init ();

//	// extern void sbevent_free (sbevent_t *evt);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void sbevent_free (sbevent_t* evt);

//	// extern int sbevent_signal (sbevent_t *evt);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sbevent_signal (sbevent_t* evt);

//	// extern int sbevent_wait (sbevent_t *evt, int sec, int nsec);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int sbevent_wait (sbevent_t* evt, int sec, int nsec);

//	// extern char * string_join (const char *base, ...);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* string_join (sbyte* @base, IntPtr varArgs);

//	// extern char * string_trim (char *string, enum string_edge_e which);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe sbyte* string_trim (sbyte* @string, string_edge_e which);

//	// extern double atof_c (const char *str);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe double atof_c (sbyte* str);

//	// extern int32 str2words (char *line, char **wptr, int32 n_wptr);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int str2words (sbyte* line, sbyte** wptr, int n_wptr);

//	// extern int32 nextword (char *line, const char *delim, char **word, char *delimfound);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int nextword (sbyte* line, sbyte* delim, sbyte** word, sbyte* delimfound);

//	// extern yin_t * yin_init (int frame_size, float search_threshold, float search_range, int smooth_window);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe yin_t* yin_init (int frame_size, float search_threshold, float search_range, int smooth_window);

//	// extern void yin_free (yin_t *pe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void yin_free (yin_t* pe);

//	// extern void yin_start (yin_t *pe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void yin_start (yin_t* pe);

//	// extern void yin_end (yin_t *pe);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void yin_end (yin_t* pe);

//	// extern void yin_write (yin_t *pe, const int16 *frame);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe void yin_write (yin_t* pe, short* frame);

//	// extern int yin_read (yin_t *pe, uint16 *out_period, uint16 *out_bestdiff);
//	[DllImport ("__Internal")]
//	[Verify (PlatformInvoke)]
//	static extern unsafe int yin_read (yin_t* pe, ushort* out_period, ushort* out_bestdiff);
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct arg_t
//{
//	public unsafe sbyte* name;

//	public int type;

//	public unsafe sbyte* deflt;

//	public unsafe sbyte* doc;
//}

//public enum fe_error_e
//{
//	Success = 0,
//	OutputFileSuccess = 0,
//	ControlFileError = -1,
//	StartError = -2,
//	UnknownSingleOrBatch = -3,
//	InputFileOpenError = -4,
//	InputFileReadError = -5,
//	MemAllocError = -6,
//	OutputFileWriteError = -7,
//	OutputFileOpenError = -8,
//	ZeroEnergyError = -9,
//	InvalidParamError = -10
//}

//public enum agc_type_t : uint
//{
//	None = 0,
//	Max,
//	Emax,
//	Noise
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct agc_t
//{
//	public float max;

//	public float obs_max;

//	public int obs_frame;

//	public int obs_utt;

//	public float obs_max_sum;

//	public float noise_thresh;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct bitarr_mask_t
//{
//	public byte bits;

//	public uint mask;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct bitarr_address_t
//{
//	public unsafe void* @base;

//	public uint offset;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct complex
//{
//	public float r;

//	public float i;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct doublecomplex
//{
//	public double r;

//	public double i;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct cilist
//{
//	public int cierr;

//	public int ciunit;

//	public int ciend;

//	public unsafe sbyte* cifmt;

//	public int cirec;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct icilist
//{
//	public int icierr;

//	public unsafe sbyte* iciunit;

//	public int iciend;

//	public unsafe sbyte* icifmt;

//	public int icirlen;

//	public int icirnum;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct olist
//{
//	public int oerr;

//	public int ounit;

//	public unsafe sbyte* ofnm;

//	public int ofnmlen;

//	public unsafe sbyte* osta;

//	public unsafe sbyte* oacc;

//	public unsafe sbyte* ofm;

//	public int orl;

//	public unsafe sbyte* oblnk;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct cllist
//{
//	public int cerr;

//	public int cunit;

//	public unsafe sbyte* csta;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct alist
//{
//	public int aerr;

//	public int aunit;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct inlist
//{
//	public int inerr;

//	public int inunit;

//	public unsafe sbyte* infile;

//	public int infilen;

//	public unsafe int* inex;

//	public unsafe int* inopen;

//	public unsafe int* innum;

//	public unsafe int* innamed;

//	public unsafe sbyte* inname;

//	public int innamlen;

//	public unsafe sbyte* inacc;

//	public int inacclen;

//	public unsafe sbyte* inseq;

//	public int inseqlen;

//	public unsafe sbyte* indir;

//	public int indirlen;

//	public unsafe sbyte* infmt;

//	public int infmtlen;

//	public unsafe sbyte* inform;

//	public int informlen;

//	public unsafe sbyte* inunf;

//	public int inunflen;

//	public unsafe int* inrecl;

//	public unsafe int* innrec;

//	public unsafe sbyte* inblank;

//	public int inblanklen;
//}

//[StructLayout (LayoutKind.Explicit)]
//public struct Multitype
//{
//	[FieldOffset (0)]
//	public short h;

//	[FieldOffset (0)]
//	public int i;

//	[FieldOffset (0)]
//	public float r;

//	[FieldOffset (0)]
//	public double d;

//	[FieldOffset (0)]
//	public complex c;

//	[FieldOffset (0)]
//	public doublecomplex z;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct Vardesc
//{
//	public unsafe sbyte* name;

//	public unsafe sbyte* addr;

//	public unsafe int* dims;

//	public int type;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct Namelist
//{
//	public unsafe sbyte* name;

//	public unsafe Vardesc** vars;

//	public int nvars;
//}

//public enum cmn_type_t : uint
//{
//	None = 0,
//	Batch,
//	Live
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct cmn_t
//{
//	public unsafe float* cmn_mean;

//	public unsafe float* cmn_var;

//	public unsafe float* sum;

//	public int nframe;

//	public int veclen;
//}

//public enum err_lvl_t : uint
//{
//	Debug,
//	Info,
//	Infocont,
//	Warn,
//	Error,
//	Fatal,
//	Max
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct feat_t
//{
//	public int refcount;

//	public unsafe sbyte* name;

//	public int cepsize;

//	public int n_stream;

//	public unsafe uint* stream_len;

//	public int window_size;

//	public int n_sv;

//	public unsafe uint* sv_len;

//	public unsafe int** subvecs;

//	public unsafe float* sv_buf;

//	public int sv_dim;

//	public cmn_type_t cmn;

//	public int varnorm;

//	public agc_type_t agc;

//	public unsafe Action<Sphinxbase_CocoaPod.feat_s*, float**, float**>* compute_feat;

//	public unsafe cmn_t* cmn_struct;

//	public unsafe agc_t* agc_struct;

//	public unsafe float** cepbuf;

//	public unsafe float** tmpcepbuf;

//	public int bufpos;

//	public int curpos;

//	public unsafe float*** lda;

//	public uint n_lda;

//	public uint out_dim;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct gnode_t
//{
//	public anytype_t data;

//	public unsafe gnode_s* next;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct logadd_s
//{
//	public unsafe void* table;

//	public uint table_size;

//	public byte width;

//	public sbyte shift;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct hash_entry_t
//{
//	public unsafe sbyte* key;

//	public nuint len;

//	public unsafe void* val;

//	public unsafe hash_entry_s* next;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct hash_table_t
//{
//	public unsafe hash_entry_t* table;

//	public int size;

//	public int inuse;

//	public int nocase;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct jsgf_rule_iter_t
//{
//	public unsafe hash_table_t* ht;

//	public unsafe hash_entry_t* ent;

//	public nuint idx;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct fsg_link_t
//{
//	public int from_state;

//	public int to_state;

//	public int logs2prob;

//	public int wid;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct fsg_model_t
//{
//	public int refcount;

//	public unsafe sbyte* name;

//	public int n_word;

//	public int n_word_alloc;

//	public unsafe sbyte** vocab;

//	public unsafe uint* silwords;

//	public unsafe uint* altwords;

//	public unsafe logmath_t* lmath;

//	public int n_state;

//	public int start_state;

//	public int final_state;

//	public float lw;

//	public unsafe trans_list_t* trans;

//	public unsafe listelem_alloc_t* link_alloc;
//}

//public enum ngram_file_type_t
//{
//	Invalid = -1,
//	Auto,
//	Arpa,
//	Bin
//}

//public enum ngram_case_t : uint
//{
//	Upper,
//	Lower
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct lineiter_t
//{
//	public unsafe sbyte* buf;

//	public unsafe FILE* fh;

//	public int bsiz;

//	public int len;

//	public int clean;

//	public int lineno;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct pctr_t
//{
//	public unsafe sbyte* name;

//	public int count;
//}

//[StructLayout (LayoutKind.Sequential)]
//public struct ptmr_t
//{
//	public unsafe sbyte* name;

//	public double t_cpu;

//	public double t_elapsed;

//	public double t_tot_cpu;

//	public double t_tot_elapsed;

//	public double start_cpu;

//	public double start_elapsed;
//}

//public enum string_edge_e : uint
//{
//	Start,
//	End,
//	Both
//}
